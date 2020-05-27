namespace ACModule
{
    partial class AC
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
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.CPA = new System.Windows.Forms.TextBox();
            this.TCPA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Velocity = new System.Windows.Forms.TextBox();
            this.Turn = new System.Windows.Forms.TextBox();
            this.SetCPA = new System.Windows.Forms.Button();
            this.SetVelTurn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TCPALimTxt = new System.Windows.Forms.Label();
            this.CPALimTxt = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TurnLimTxt = new System.Windows.Forms.Label();
            this.VelLimTxt = new System.Windows.Forms.Label();
            this.MessageDisplay = new System.Windows.Forms.Label();
            this.HostName = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(104, 210);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(66, 34);
            this.Stop.TabIndex = 0;
            this.Stop.Text = "STOP  Module";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(176, 210);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(65, 34);
            this.Start.TabIndex = 1;
            this.Start.Text = "START Module";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // CPA
            // 
            this.CPA.Location = new System.Drawing.Point(117, 15);
            this.CPA.Name = "CPA";
            this.CPA.Size = new System.Drawing.Size(100, 20);
            this.CPA.TabIndex = 2;
            // 
            // TCPA
            // 
            this.TCPA.Location = new System.Drawing.Point(117, 43);
            this.TCPA.Name = "TCPA";
            this.TCPA.Size = new System.Drawing.Size(100, 20);
            this.TCPA.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CPA Limit [m]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TCPA Limit [min]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Speed Limit [m/s]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Turn Limit [ ° ]";
            // 
            // Velocity
            // 
            this.Velocity.Location = new System.Drawing.Point(117, 13);
            this.Velocity.Name = "Velocity";
            this.Velocity.Size = new System.Drawing.Size(100, 20);
            this.Velocity.TabIndex = 8;
            // 
            // Turn
            // 
            this.Turn.Location = new System.Drawing.Point(117, 39);
            this.Turn.Name = "Turn";
            this.Turn.Size = new System.Drawing.Size(100, 20);
            this.Turn.TabIndex = 9;
            // 
            // SetCPA
            // 
            this.SetCPA.Location = new System.Drawing.Point(272, 27);
            this.SetCPA.Name = "SetCPA";
            this.SetCPA.Size = new System.Drawing.Size(50, 23);
            this.SetCPA.TabIndex = 10;
            this.SetCPA.Text = "Set";
            this.SetCPA.UseVisualStyleBackColor = true;
            this.SetCPA.Click += new System.EventHandler(this.SetCPA_Click);
            // 
            // SetVelTurn
            // 
            this.SetVelTurn.Location = new System.Drawing.Point(272, 27);
            this.SetVelTurn.Name = "SetVelTurn";
            this.SetVelTurn.Size = new System.Drawing.Size(49, 23);
            this.SetVelTurn.TabIndex = 11;
            this.SetVelTurn.Text = "Set";
            this.SetVelTurn.UseVisualStyleBackColor = true;
            this.SetVelTurn.Click += new System.EventHandler(this.SetVelTurn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TCPALimTxt);
            this.groupBox1.Controls.Add(this.CPALimTxt);
            this.groupBox1.Controls.Add(this.SetCPA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CPA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TCPA);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 73);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // TCPALimTxt
            // 
            this.TCPALimTxt.AutoSize = true;
            this.TCPALimTxt.Location = new System.Drawing.Point(224, 46);
            this.TCPALimTxt.Name = "TCPALimTxt";
            this.TCPALimTxt.Size = new System.Drawing.Size(35, 13);
            this.TCPALimTxt.TabIndex = 12;
            this.TCPALimTxt.Text = "label9";
            // 
            // CPALimTxt
            // 
            this.CPALimTxt.AutoSize = true;
            this.CPALimTxt.Location = new System.Drawing.Point(224, 18);
            this.CPALimTxt.Name = "CPALimTxt";
            this.CPALimTxt.Size = new System.Drawing.Size(35, 13);
            this.CPALimTxt.TabIndex = 11;
            this.CPALimTxt.Text = "label9";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TurnLimTxt);
            this.groupBox2.Controls.Add(this.VelLimTxt);
            this.groupBox2.Controls.Add(this.SetVelTurn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Turn);
            this.groupBox2.Controls.Add(this.Velocity);
            this.groupBox2.Location = new System.Drawing.Point(6, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 69);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // TurnLimTxt
            // 
            this.TurnLimTxt.AutoSize = true;
            this.TurnLimTxt.Location = new System.Drawing.Point(224, 42);
            this.TurnLimTxt.Name = "TurnLimTxt";
            this.TurnLimTxt.Size = new System.Drawing.Size(35, 13);
            this.TurnLimTxt.TabIndex = 14;
            this.TurnLimTxt.Text = "label9";
            // 
            // VelLimTxt
            // 
            this.VelLimTxt.AutoSize = true;
            this.VelLimTxt.Location = new System.Drawing.Point(224, 16);
            this.VelLimTxt.Name = "VelLimTxt";
            this.VelLimTxt.Size = new System.Drawing.Size(35, 13);
            this.VelLimTxt.TabIndex = 13;
            this.VelLimTxt.Text = "label9";
            // 
            // MessageDisplay
            // 
            this.MessageDisplay.AutoEllipsis = true;
            this.MessageDisplay.Location = new System.Drawing.Point(6, 17);
            this.MessageDisplay.Name = "MessageDisplay";
            this.MessageDisplay.Size = new System.Drawing.Size(241, 32);
            this.MessageDisplay.TabIndex = 14;
            this.MessageDisplay.Text = "_";
            // 
            // HostName
            // 
            this.HostName.Location = new System.Drawing.Point(117, 19);
            this.HostName.Name = "HostName";
            this.HostName.Size = new System.Drawing.Size(100, 20);
            this.HostName.TabIndex = 15;
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(117, 45);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 20);
            this.Port.TabIndex = 16;
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(236, 27);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(75, 32);
            this.bConnect.TabIndex = 17;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bConnect);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.HostName);
            this.groupBox3.Controls.Add(this.Port);
            this.groupBox3.Location = new System.Drawing.Point(6, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 73);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Host Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.MessageDisplay);
            this.groupBox4.Location = new System.Drawing.Point(50, 152);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 52);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Message";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, -3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Message";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 331);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AC";
            this.Text = "Anticollision Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AC_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox CPA;
        private System.Windows.Forms.TextBox TCPA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Velocity;
        private System.Windows.Forms.TextBox Turn;
        private System.Windows.Forms.Button SetCPA;
        private System.Windows.Forms.Button SetVelTurn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label MessageDisplay;
        private System.Windows.Forms.TextBox HostName;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CPALimTxt;
        private System.Windows.Forms.Label TCPALimTxt;
        private System.Windows.Forms.Label TurnLimTxt;
        private System.Windows.Forms.Label VelLimTxt;
    }
}