namespace practice
{
    partial class frmClient
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
            this.rchtxtbxLog = new System.Windows.Forms.RichTextBox();
            this.txtbxMsg = new System.Windows.Forms.TextBox();
            this.bttnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtbxLog
            // 
            this.rchtxtbxLog.Location = new System.Drawing.Point(23, 21);
            this.rchtxtbxLog.Name = "rchtxtbxLog";
            this.rchtxtbxLog.Size = new System.Drawing.Size(236, 163);
            this.rchtxtbxLog.TabIndex = 0;
            this.rchtxtbxLog.Text = "";
            // 
            // txtbxMsg
            // 
            this.txtbxMsg.Location = new System.Drawing.Point(23, 210);
            this.txtbxMsg.Name = "txtbxMsg";
            this.txtbxMsg.Size = new System.Drawing.Size(174, 21);
            this.txtbxMsg.TabIndex = 1;
            this.txtbxMsg.TextChanged += new System.EventHandler(this.txtbxMsg_TextChanged);
            this.txtbxMsg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxMsg_KeyPress);
            // 
            // bttnSend
            // 
            this.bttnSend.Location = new System.Drawing.Point(204, 210);
            this.bttnSend.Name = "bttnSend";
            this.bttnSend.Size = new System.Drawing.Size(55, 23);
            this.bttnSend.TabIndex = 2;
            this.bttnSend.Text = "Send";
            this.bttnSend.UseVisualStyleBackColor = true;
            this.bttnSend.Click += new System.EventHandler(this.bttnSend_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bttnSend);
            this.Controls.Add(this.txtbxMsg);
            this.Controls.Add(this.rchtxtbxLog);
            this.Name = "frmClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtbxLog;
        private System.Windows.Forms.TextBox txtbxMsg;
        private System.Windows.Forms.Button bttnSend;
    }
}