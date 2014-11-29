namespace practice
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioServer = new System.Windows.Forms.RadioButton();
            this.radioClient = new System.Windows.Forms.RadioButton();
            this.txtbxIP1 = new System.Windows.Forms.TextBox();
            this.txtbxIP2 = new System.Windows.Forms.TextBox();
            this.txtbxIP3 = new System.Windows.Forms.TextBox();
            this.txtbxIP4 = new System.Windows.Forms.TextBox();
            this.txtbxPort = new System.Windows.Forms.TextBox();
            this.bttnStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioServer
            // 
            this.radioServer.AutoSize = true;
            this.radioServer.Location = new System.Drawing.Point(66, 33);
            this.radioServer.Name = "radioServer";
            this.radioServer.Size = new System.Drawing.Size(59, 16);
            this.radioServer.TabIndex = 0;
            this.radioServer.TabStop = true;
            this.radioServer.Text = "Server";
            this.radioServer.UseVisualStyleBackColor = true;
            this.radioServer.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioClient
            // 
            this.radioClient.AutoSize = true;
            this.radioClient.Location = new System.Drawing.Point(154, 33);
            this.radioClient.Name = "radioClient";
            this.radioClient.Size = new System.Drawing.Size(55, 16);
            this.radioClient.TabIndex = 1;
            this.radioClient.TabStop = true;
            this.radioClient.Text = "Client";
            this.radioClient.UseVisualStyleBackColor = true;
            this.radioClient.CheckedChanged += new System.EventHandler(this.radioClient_CheckedChanged);
            // 
            // txtbxIP1
            // 
            this.txtbxIP1.Location = new System.Drawing.Point(22, 86);
            this.txtbxIP1.Name = "txtbxIP1";
            this.txtbxIP1.Size = new System.Drawing.Size(38, 21);
            this.txtbxIP1.TabIndex = 2;
            this.txtbxIP1.TextChanged += new System.EventHandler(this.txtbxIP1_TextChanged);
            // 
            // txtbxIP2
            // 
            this.txtbxIP2.Location = new System.Drawing.Point(66, 86);
            this.txtbxIP2.Name = "txtbxIP2";
            this.txtbxIP2.Size = new System.Drawing.Size(38, 21);
            this.txtbxIP2.TabIndex = 3;
            this.txtbxIP2.TextChanged += new System.EventHandler(this.txtbxIP2_TextChanged);
            // 
            // txtbxIP3
            // 
            this.txtbxIP3.Location = new System.Drawing.Point(110, 86);
            this.txtbxIP3.Name = "txtbxIP3";
            this.txtbxIP3.Size = new System.Drawing.Size(38, 21);
            this.txtbxIP3.TabIndex = 4;
            this.txtbxIP3.TextChanged += new System.EventHandler(this.txtbxIP3_TextChanged);
            // 
            // txtbxIP4
            // 
            this.txtbxIP4.Location = new System.Drawing.Point(154, 86);
            this.txtbxIP4.Name = "txtbxIP4";
            this.txtbxIP4.Size = new System.Drawing.Size(38, 21);
            this.txtbxIP4.TabIndex = 5;
            this.txtbxIP4.TextChanged += new System.EventHandler(this.txtbxIP4_TextChanged);
            // 
            // txtbxPort
            // 
            this.txtbxPort.Location = new System.Drawing.Point(198, 86);
            this.txtbxPort.Name = "txtbxPort";
            this.txtbxPort.Size = new System.Drawing.Size(38, 21);
            this.txtbxPort.TabIndex = 6;
            this.txtbxPort.TextChanged += new System.EventHandler(this.txtbxPort_TextChanged);
            // 
            // bttnStart
            // 
            this.bttnStart.Location = new System.Drawing.Point(245, 86);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(75, 23);
            this.bttnStart.TabIndex = 7;
            this.bttnStart.Text = "Connect";
            this.bttnStart.UseVisualStyleBackColor = true;
            this.bttnStart.Click += new System.EventHandler(this.bttnStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(88, 21);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "IP address v4";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(198, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(38, 21);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Port";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 142);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bttnStart);
            this.Controls.Add(this.txtbxPort);
            this.Controls.Add(this.txtbxIP4);
            this.Controls.Add(this.txtbxIP3);
            this.Controls.Add(this.txtbxIP2);
            this.Controls.Add(this.txtbxIP1);
            this.Controls.Add(this.radioClient);
            this.Controls.Add(this.radioServer);
            this.Name = "frmMain";
            this.Text = "Chatter";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioServer;
        private System.Windows.Forms.RadioButton radioClient;
        private System.Windows.Forms.TextBox txtbxIP1;
        private System.Windows.Forms.TextBox txtbxIP2;
        private System.Windows.Forms.TextBox txtbxIP3;
        private System.Windows.Forms.TextBox txtbxIP4;
        private System.Windows.Forms.TextBox txtbxPort;
        private System.Windows.Forms.Button bttnStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

