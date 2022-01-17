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
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址：";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(73, 14);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(150, 21);
            this.textBoxIP.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(241, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(322, 13);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "断开";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(20, 57);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(75, 23);
            this.btnEnable.TabIndex = 4;
            this.btnEnable.Text = "使能";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(106, 57);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(75, 23);
            this.btnDisable.TabIndex = 4;
            this.btnDisable.Text = "急停";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "速度比例：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "%";
            // 
            // richBoxResult
            // 
            this.richBoxResult.Location = new System.Drawing.Point(442, 12);
            this.richBoxResult.Name = "richBoxResult";
            this.richBoxResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richBoxResult.Size = new System.Drawing.Size(396, 455);
            this.richBoxResult.TabIndex = 12;
            this.richBoxResult.Text = "";
            // 
            // labelNowSpeedFactor
            // 
            this.labelNowSpeedFactor.AutoSize = true;
            this.labelNowSpeedFactor.Location = new System.Drawing.Point(226, 100);
            this.labelNowSpeedFactor.Name = "labelNowSpeedFactor";
            this.labelNowSpeedFactor.Size = new System.Drawing.Size(89, 12);
            this.labelNowSpeedFactor.TabIndex = 9;
            this.labelNowSpeedFactor.Text = "当前速度比例：";
            // 
            // labelRobotMode
            // 
            this.labelRobotMode.AutoSize = true;
            this.labelRobotMode.Location = new System.Drawing.Point(17, 136);
            this.labelRobotMode.Name = "labelRobotMode";
            this.labelRobotMode.Size = new System.Drawing.Size(77, 12);
            this.labelRobotMode.TabIndex = 9;
            this.labelRobotMode.Text = "机器人模式：";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(191, 57);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清除错误";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(84, 96);
            this.textBoxSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSpeed.MaxLength = 3;
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(41, 21);
            this.textBoxSpeed.TabIndex = 13;
            // 
            // btnSetSpeed
            // 
            this.btnSetSpeed.Location = new System.Drawing.Point(145, 92);
            this.btnSetSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetSpeed.Name = "btnSetSpeed";
            this.btnSetSpeed.Size = new System.Drawing.Size(76, 28);
            this.btnSetSpeed.TabIndex = 14;
            this.btnSetSpeed.Text = "设置速度";
            this.btnSetSpeed.UseVisualStyleBackColor = true;
            this.btnSetSpeed.Click += new System.EventHandler(this.btnSetSpeed_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(442, 473);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(141, 28);
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
            this.groupBox1.Location = new System.Drawing.Point(19, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 148);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "关节坐标";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "J1：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxJt1
            // 
            this.textBoxJt1.BackColor = System.Drawing.Color.White;
            this.textBoxJt1.Location = new System.Drawing.Point(47, 29);
            this.textBoxJt1.Name = "textBoxJt1";
            this.textBoxJt1.ReadOnly = true;
            this.textBoxJt1.Size = new System.Drawing.Size(100, 21);
            this.textBoxJt1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "J2：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "J3：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxJt2
            // 
            this.textBoxJt2.BackColor = System.Drawing.Color.White;
            this.textBoxJt2.Location = new System.Drawing.Point(47, 58);
            this.textBoxJt2.Name = "textBoxJt2";
            this.textBoxJt2.ReadOnly = true;
            this.textBoxJt2.Size = new System.Drawing.Size(100, 21);
            this.textBoxJt2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "J4：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxJt3
            // 
            this.textBoxJt3.BackColor = System.Drawing.Color.White;
            this.textBoxJt3.Location = new System.Drawing.Point(47, 87);
            this.textBoxJt3.Name = "textBoxJt3";
            this.textBoxJt3.ReadOnly = true;
            this.textBoxJt3.Size = new System.Drawing.Size(100, 21);
            this.textBoxJt3.TabIndex = 13;
            // 
            // textBoxJt4
            // 
            this.textBoxJt4.BackColor = System.Drawing.Color.White;
            this.textBoxJt4.Location = new System.Drawing.Point(47, 117);
            this.textBoxJt4.Name = "textBoxJt4";
            this.textBoxJt4.ReadOnly = true;
            this.textBoxJt4.Size = new System.Drawing.Size(100, 21);
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
            this.groupBox2.Location = new System.Drawing.Point(215, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 148);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "笛卡尔坐标";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "X：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxX
            // 
            this.textBoxX.BackColor = System.Drawing.Color.White;
            this.textBoxX.Location = new System.Drawing.Point(43, 29);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(100, 21);
            this.textBoxX.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "Y：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "Z：";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxY
            // 
            this.textBoxY.BackColor = System.Drawing.Color.White;
            this.textBoxY.Location = new System.Drawing.Point(43, 59);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(100, 21);
            this.textBoxY.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "R：";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxZ
            // 
            this.textBoxZ.BackColor = System.Drawing.Color.White;
            this.textBoxZ.Location = new System.Drawing.Point(43, 89);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.ReadOnly = true;
            this.textBoxZ.Size = new System.Drawing.Size(100, 21);
            this.textBoxZ.TabIndex = 13;
            // 
            // textBoxR
            // 
            this.textBoxR.BackColor = System.Drawing.Color.White;
            this.textBoxR.Location = new System.Drawing.Point(43, 118);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.ReadOnly = true;
            this.textBoxR.Size = new System.Drawing.Size(100, 21);
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
            this.groupBox3.Location = new System.Drawing.Point(20, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 121);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输入目标点位";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(291, 22);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 6;
            this.label19.Text = "毫米";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(294, 56);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 5;
            this.label18.Text = "度";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(127, 60);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 4;
            this.label17.Text = "毫米";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(128, 22);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 3;
            this.label16.Text = "毫米";
            // 
            // btnMovJ
            // 
            this.btnMovJ.Location = new System.Drawing.Point(107, 92);
            this.btnMovJ.Name = "btnMovJ";
            this.btnMovJ.Size = new System.Drawing.Size(140, 23);
            this.btnMovJ.TabIndex = 2;
            this.btnMovJ.Text = "MovJ";
            this.btnMovJ.UseVisualStyleBackColor = true;
            this.btnMovJ.Click += new System.EventHandler(this.btnMovJ_Click);
            // 
            // textBoxRInput
            // 
            this.textBoxRInput.Location = new System.Drawing.Point(208, 52);
            this.textBoxRInput.Name = "textBoxRInput";
            this.textBoxRInput.Size = new System.Drawing.Size(80, 21);
            this.textBoxRInput.TabIndex = 1;
            // 
            // textBoxZInput
            // 
            this.textBoxZInput.Location = new System.Drawing.Point(207, 18);
            this.textBoxZInput.Name = "textBoxZInput";
            this.textBoxZInput.Size = new System.Drawing.Size(80, 21);
            this.textBoxZInput.TabIndex = 1;
            // 
            // textBoxYInput
            // 
            this.textBoxYInput.Location = new System.Drawing.Point(40, 56);
            this.textBoxYInput.Name = "textBoxYInput";
            this.textBoxYInput.Size = new System.Drawing.Size(80, 21);
            this.textBoxYInput.TabIndex = 1;
            // 
            // textBoxXInput
            // 
            this.textBoxXInput.Location = new System.Drawing.Point(41, 18);
            this.textBoxXInput.Name = "textBoxXInput";
            this.textBoxXInput.Size = new System.Drawing.Size(80, 21);
            this.textBoxXInput.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(180, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "R：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(178, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "Z：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Y：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "X：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 510);
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