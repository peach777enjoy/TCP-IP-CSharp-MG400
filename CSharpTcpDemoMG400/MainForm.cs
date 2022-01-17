using CSharpTcpDemo.com.dobot.api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpTcpDemo
{
    public partial class MainForm : Form
    {
        private Feedback mFeedback = new Feedback();
        private Dashboard mDashboard = new Dashboard();

        //定时获取数据并显示到UI
        private System.Timers.Timer mTimerReader = new System.Timers.Timer(500);

        public MainForm()
        {
            InitializeComponent();

            this.textBoxIP.Text = "192.168.1.6";

            this.textBoxSpeed.Text = "10";

            this.textBoxXInput.Text = "10.0";
            this.textBoxYInput.Text = "10.0";
            this.textBoxZInput.Text = "10.0";
            this.textBoxRInput.Text = "0.0";

            labelNowSpeedFactor.Hide();

            //启动定时器
            mTimerReader.Elapsed += new System.Timers.ElapsedEventHandler(TimeoutEvent);
            mTimerReader.AutoReset = true;

            //默认禁止窗口中的大部分控件
            DisableWindow();
        }

        private void DisableWindow()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is Button)
                {
                    ctr.Enabled = false;
                }
                else if (ctr is Panel)
                {
                    ctr.Enabled = false;
                }
            }
            this.btnConnect.Enabled = true; ;
        }

        private void EnableWindow()
        {
            foreach (Control ctr in this.Controls)
            {
                ctr.Enabled = true;
            }
            this.btnConnect.Enabled = false;
        }
    
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mTimerReader.Close();
            if (this.mFeedback != null)
            {
                this.mFeedback.Disconnect();
            }
            if (this.mDashboard != null)
            {
                this.mDashboard.Disconnect();
            }
        }

        private bool IsValidIP(string strIp)
        {
            try
            {
                IPAddress.Parse(strIp);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void InsertMsgToRichBox(string str)
        {
            if (this.richBoxResult.GetLineFromCharIndex(this.richBoxResult.TextLength) > 500)
            {
                this.richBoxResult.Text = str += "\r\n";
            }
            else
            {
                this.richBoxResult.Text += (str + "\r\n");
            }
            this.richBoxResult.Focus();
            this.richBoxResult.Select(this.richBoxResult.TextLength, 0);
            this.richBoxResult.ScrollToCaret();
        }

        private void PrintLog(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return;
            }
            if (this.richBoxResult.InvokeRequired)
            {
                this.richBoxResult.Invoke(new Action<string>(log=> {
                    InsertMsgToRichBox(log);
                }),str);
            }
            else
            {
                InsertMsgToRichBox(str);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string strIp = textBoxIP.Text;
            if (string.IsNullOrEmpty(strIp))
            {
                MessageBox.Show("请输入IP地址");
                return;
            }
            if (!IsValidIP(strIp))
            {
                MessageBox.Show("IP地址输入格式不正确");
                return;
            }

            PrintLog("正在连接设备...");
            Thread thd = new Thread(()=> {
                if (!mFeedback.Connect(strIp))
                {
                    PrintLog(string.Format("连接 {0} 失败!!", strIp));
                    return;
                }
                if (!mDashboard.Connect(strIp))
                {
                    PrintLog(string.Format("连接 {0} 失败!!", strIp));
                    return;
                }

                mTimerReader.Start();

                PrintLog("连接成功!!!");

                this.Invoke(new Action(()=> {
                    EnableWindow();
                }));
            });
            thd.Start();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            PrintLog("正在断开...");
            Thread thd = new Thread(()=>{
                mFeedback.Disconnect();
                mDashboard.Disconnect();
                PrintLog("断开连接完成!!!");

                mTimerReader.Stop();

                this.Invoke(new Action(()=>{
                    DisableWindow();
                }));
            });
            thd.Start();
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            PrintLog("正在执行使能动作...");
            Thread thd = new Thread(() =>{
                string strRet = mDashboard.EnableRobot();
                PrintLog("EnableRobot: " + strRet);
                PrintLog("使能动作执行完毕!!!");
            });
            thd.Start();
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            PrintLog("正在执行禁止动作...");
            Thread thd = new Thread(() =>{
                string strRet = mDashboard.DisableRobot();
                PrintLog("DisableRobot: " + strRet);
                PrintLog("禁止动作执行完毕!!!");
            });
            thd.Start();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            PrintLog("正在执行清除错误动作...");
            Thread thd = new Thread(() =>{
                string strRet = mDashboard.ClearError();
                PrintLog("ClearError: " + strRet);
                PrintLog("清除错误动作执行完毕!!!");
            });
            thd.Start();
        }

        private void btnSetSpeed_Click(object sender, EventArgs e)
        {
            int iValue = 0;
            try
            {
                iValue = Int32.Parse(this.textBoxSpeed.Text);
            }
            catch
            {
            }
            PrintLog("正在设置速度比例...");
            Thread thd = new Thread(() => {
                string strRet = mDashboard.SpeedFactor(iValue);
                PrintLog("SpeedFactor: " + strRet);
                PrintLog("速度比例设置完毕!!!");
            });
            thd.Start();
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            this.richBoxResult.Clear();
        }

        private void ShowJointData()
        {
            if (null != mFeedback.QActual && mFeedback.QActual.Length >= 6)
            {
                this.textBoxJt1.Text = string.Format("{0:F3}", mFeedback.QActual[0]);
                this.textBoxJt2.Text = string.Format("{0:F3}", mFeedback.QActual[1]);
                this.textBoxJt3.Text = string.Format("{0:F3}", mFeedback.QActual[2]);
                this.textBoxJt4.Text = string.Format("{0:F3}", mFeedback.QActual[3]);
            }
        }
        private void ShowXYZRData()
        {

            if (null != mFeedback.ToolVectorActual && mFeedback.ToolVectorActual.Length >= 6)
            {
                this.textBoxX.Text = string.Format("{0:F3}", mFeedback.ToolVectorActual[0]);
                this.textBoxY.Text = string.Format("{0:F3}", mFeedback.ToolVectorActual[1]);
                this.textBoxZ.Text = string.Format("{0:F3}", mFeedback.ToolVectorActual[2]);
                this.textBoxR.Text = string.Format("{0:F3}", mFeedback.ToolVectorActual[3]);
            }
        }

        private void ShowTextboxData()
        {
            this.labelNowSpeedFactor.Text = string.Format("当前速度比例：{0:F2}%", mFeedback.SpeedScaling);
            this.labelRobotMode.Text = string.Format("机器人模式：{0}", mFeedback.ConvertRobotMode());
            ShowJointData();
            ShowXYZRData();
        }
        private void TimeoutEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!mFeedback.DataHasRead)
            {
                return;
            }
            mFeedback.DataHasRead = false;

            if (this.labelNowSpeedFactor.InvokeRequired)
            {
                this.labelNowSpeedFactor.Invoke(new Action(() =>{
                    ShowTextboxData();
                }));
            }
            else
            {
                ShowTextboxData();
            }
        }

        private double Convert2Double(string str)
        {
            double value = 0.0;
            if (string.IsNullOrEmpty(str))
            {
                return value;
            }
            try
            {
                value = Double.Parse(str);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.ToString());
            }
            return value;
        }

        private void btnMovJ_Click(object sender, EventArgs e)
        {
            double x = Convert2Double(this.textBoxXInput.Text);
            double y = Convert2Double(this.textBoxYInput.Text);
            double z = Convert2Double(this.textBoxZInput.Text);
            double r = Convert2Double(this.textBoxRInput.Text);

            PrintLog(string.Format("正在执行 MovJ 动作..."));
            Thread thd = new Thread(() => {
                string ret = mFeedback.MovJ(x,y,z,r) ? "成功" : "失败";
                PrintLog(string.Format("MovJ 动作执行{0}", ret));
            });
            thd.Start();
        }
    }
}
