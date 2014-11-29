namespace practice
{
    partial class frmServer
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
            this.txtbxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richbxLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtbxPort
            // 
            this.txtbxPort.Location = new System.Drawing.Point(130, 26);
            this.txtbxPort.Name = "txtbxPort";
            this.txtbxPort.ReadOnly = true;
            this.txtbxPort.Size = new System.Drawing.Size(52, 21);
            this.txtbxPort.TabIndex = 0;
            this.txtbxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richbxLog
            // 
            this.richbxLog.Location = new System.Drawing.Point(41, 53);
            this.richbxLog.Name = "richbxLog";
            this.richbxLog.Size = new System.Drawing.Size(203, 180);
            this.richbxLog.TabIndex = 2;
            this.richbxLog.Text = "";
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.richbxLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxPort);
            this.Name = "frmServer";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richbxLog;
    }
}