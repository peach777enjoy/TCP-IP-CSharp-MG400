namespace CSharpTcpDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.richBoxResult = new System.Windows.Forms.RichTextBox();
            this.labelNowSpeedFactor = new System.Windows.Forms.Label();
            this.labelRobotMode = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.btnSetSpeed = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxJt1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxJt2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxJt3 = new System.Windows.Forms.TextBox();
            this.textBoxJt4 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnMovJ = new System.Windows.Forms.Button();
            this.textBoxRInput = new System.Windows.Forms.TextBox();
            this.textBoxZInput = new System.Windows.Forms.TextBox();
            this.textBoxYInput = new System.Windows.Forms.TextBox();
            this.textBoxXInput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址：";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(97, 18);
            this.textBoxIP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(199, 25);
            this.textBoxIP.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(321, 16);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 29);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(429, 16);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 29);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "断开";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(27, 71);
            this.btnEnable.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(100, 29);
            this.btnEnable.TabIndex = 4;
            this.btnEnable.Text = "使能";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(141, 71);
            this.btnDisable.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(100, 29);
            this.btnDisable.TabIndex = 4;
            this.btnDisable.Text = "急停";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "速度比例：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 125);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "%";
            // 
            // richBoxResult
            // 
            this.richBoxResult.Location = new System.Drawing.Point(589, 15);
            this.richBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.richBoxResult.Name = "richBoxResult";
            this.richBoxResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richBoxResult.Size = new System.Drawing.Size(527, 568);
            this.richBoxResult.TabIndex = 12;
            this.richBoxResult.Text = "";
            // 
            // labelNowSpeedFactor
            // 
            this.labelNowSpeedFactor.AutoSize = true;
            this.labelNowSpeedFactor.Location = new System.Drawing.Point(301, 125);
            this.labelNowSpeedFactor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNowSpeedFactor.Name = "labelNowSpeedFactor";
            this.labelNowSpeedFactor.Size = new System.Drawing.Size(112, 15);
            this.labelNowSpeedFactor.TabIndex = 9;
            this.labelNowSpeedFactor.Text = "当前速度比例：";
            // 
            // labelRobotMode
            // 
            this.labelRobotMode.AutoSize = true;
            this.labelRobotMode.Location = new System.Drawing.Point(23, 170);
            this.labelRobotMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRobotMode.Name = "labelRobotMode";
            this.labelRobotMode.Size = new System.Drawing.Size(97, 15);
            this.labelRobotMode.TabIndex = 9;
            this.labelRobotMode.Text = "机器人模式：";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(255, 71);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清除错误";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(112, 120);
            this.textBoxSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSpeed.MaxLength = 3;
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(53, 25);
            this.textBoxSpeed.TabIndex = 13;
            // 
            // btnSetSpeed
            // 
            this.btnSetSpeed.Location = new System.Drawing.Point(193, 115);
            this.btnSetSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetSpeed.Name = "btnSetSpeed";
            this.btnSetSpeed.Size = new System.Drawing.Size(101, 35);
            this.btnSetSpeed.TabIndex = 14;
            this.btnSetSpeed.Text = "设置速度";
            this.btnSetSpeed.UseVisualStyleBackColor = true;
            this.btnSetSpeed.Click += new System.EventHandler(this.btnSetSpeed_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(589, 591);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(188, 35);
            this.btnClearLog.TabIndex = 15;
            this.btnClearLog.Text = "清除日志";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxJt1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxJt2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxJt3);
            this.groupBox1.Controls.Add(this.textBoxJt4);
            this.groupBox1.Location = new System.Drawing.Point(25, 212);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(204, 185);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "关节坐标";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "X：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxJt1
            // 
            this.textBoxJt1.BackColor = System.Drawing.Color.White;
            this.textBoxJt1.Location = new System.Drawing.Point(48, 36);
            this.textBoxJt1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxJt1.Name = "textBoxJt1";
            this.textBoxJt1.ReadOnly = true;
            this.textBoxJt1.Size = new System.Drawing.Size(132, 25);
            this.textBoxJt1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Y：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Z：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxJt2
            // 
            this.textBoxJt2.BackColor = System.Drawing.Color.White;
            this.textBoxJt2.Location = new System.Drawing.Point(48, 72);
            this.textBoxJt2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxJt2.Name = "textBoxJt2";
            this.textBoxJt2.ReadOnly = true;
            this.textBoxJt2.Size = new System.Drawing.Size(132, 25);
            this.textBoxJt2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "R：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxJt3
            // 
            this.textBoxJt3.BackColor = System.Drawing.Color.White;
            this.textBoxJt3.Location = new System.Drawing.Point(48, 109);
            this.textBoxJt3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxJt3.Name = "textBoxJt3";
            this.textBoxJt3.ReadOnly = true;
            this.textBoxJt3.Size = new System.Drawing.Size(132, 25);
            this.textBoxJt3.TabIndex = 13;
            // 
            // textBoxJt4
            // 
            this.textBoxJt4.BackColor = System.Drawing.Color.White;
            this.textBoxJt4.Location = new System.Drawing.Point(48, 146);
            this.textBoxJt4.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxJt4.Name = "textBoxJt4";
            this.textBoxJt4.ReadOnly = true;
            this.textBoxJt4.Size = new System.Drawing.Size(132, 25);
            this.textBoxJt4.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxX);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxY);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBoxZ);
            this.groupBox2.Controls.Add(this.textBoxR);
            this.groupBox2.Location = new System.Drawing.Point(287, 212);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(219, 185);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "笛卡尔坐标";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "X：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxX
            // 
            this.textBoxX.BackColor = System.Drawing.Color.White;
            this.textBoxX.Location = new System.Drawing.Point(57, 36);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(132, 25);
            this.textBoxX.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 79);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Y：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 116);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Z：";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxY
            // 
            this.textBoxY.BackColor = System.Drawing.Color.White;
            this.textBoxY.Location = new System.Drawing.Point(57, 74);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(132, 25);
            this.textBoxY.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 152);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "R：";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxZ
            // 
            this.textBoxZ.BackColor = System.Drawing.Color.White;
            this.textBoxZ.Location = new System.Drawing.Point(57, 111);
            this.textBoxZ.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.ReadOnly = true;
            this.textBoxZ.Size = new System.Drawing.Size(132, 25);
            this.textBoxZ.TabIndex = 13;
            // 
            // textBoxR
            // 
            this.textBoxR.BackColor = System.Drawing.Color.White;
            this.textBoxR.Location = new System.Drawing.Point(57, 148);
            this.textBoxR.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.ReadOnly = true;
            this.textBoxR.Size = new System.Drawing.Size(132, 25);
            this.textBoxR.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.btnMovJ);
            this.groupBox3.Controls.Add(this.textBoxRInput);
            this.groupBox3.Controls.Add(this.textBoxZInput);
            this.groupBox3.Controls.Add(this.textBoxYInput);
            this.groupBox3.Controls.Add(this.textBoxXInput);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(27, 432);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(479, 151);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输入目标点位";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(171, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 15);
            this.label16.TabIndex = 3;
            this.label16.Text = "毫米";
            // 
            // btnMovJ
            // 
            this.btnMovJ.Location = new System.Drawing.Point(143, 115);
            this.btnMovJ.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovJ.Name = "btnMovJ";
            this.btnMovJ.Size = new System.Drawing.Size(187, 29);
            this.btnMovJ.TabIndex = 2;
            this.btnMovJ.Text = "MovJ";
            this.btnMovJ.UseVisualStyleBackColor = true;
            this.btnMovJ.Click += new System.EventHandler(this.btnMovJ_Click);
            // 
            // textBoxRInput
            // 
            this.textBoxRInput.Location = new System.Drawing.Point(277, 65);
            this.textBoxRInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRInput.Name = "textBoxRInput";
            this.textBoxRInput.Size = new System.Drawing.Size(105, 25);
            this.textBoxRInput.TabIndex = 1;
            // 
            // textBoxZInput
            // 
            this.textBoxZInput.Location = new System.Drawing.Point(276, 23);
            this.textBoxZInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZInput.Name = "textBoxZInput";
            this.textBoxZInput.Size = new System.Drawing.Size(105, 25);
            this.textBoxZInput.TabIndex = 1;
            // 
            // textBoxYInput
            // 
            this.textBoxYInput.Location = new System.Drawing.Point(53, 70);
            this.textBoxYInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYInput.Name = "textBoxYInput";
            this.textBoxYInput.Size = new System.Drawing.Size(105, 25);
            this.textBoxYInput.TabIndex = 1;
            // 
            // textBoxXInput
            // 
            this.textBoxXInput.Location = new System.Drawing.Point(55, 22);
            this.textBoxXInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxXInput.Name = "textBoxXInput";
            this.textBoxXInput.Size = new System.Drawing.Size(105, 25);
            this.textBoxXInput.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(240, 70);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "R：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(237, 26);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Z：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Y：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "X：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(169, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 15);
            this.label17.TabIndex = 4;
            this.label17.Text = "毫米";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(392, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 15);
            this.label18.TabIndex = 5;
            this.label18.Text = "毫米";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(388, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 15);
            this.label19.TabIndex = 6;
            this.label19.Text = "毫米";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 638);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnSetSpeed);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.richBoxResult);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelRobotMode);
            this.Controls.Add(this.labelNowSpeedFactor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MG400";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richBoxResult;
        private System.Windows.Forms.Label labelNowSpeedFactor;
        private System.Windows.Forms.Label labelRobotMode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Button btnSetSpeed;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxJt1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxJt2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxJt3;
        private System.Windows.Forms.TextBox textBoxJt4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxRInput;
        private System.Windows.Forms.TextBox textBoxZInput;
        private System.Windows.Forms.TextBox textBoxYInput;
        private System.Windows.Forms.TextBox textBoxXInput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMovJ;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
    }
}