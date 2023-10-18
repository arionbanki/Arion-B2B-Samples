namespace IsIT.B2B.PublicCertDownloaderTest
{
    partial class DownloadForm
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
            this.IOBUrlTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPublicCert = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // IOBUrlTextBox
            // 
            this.IOBUrlTextBox.Location = new System.Drawing.Point(15, 25);
            this.IOBUrlTextBox.Name = "IOBUrlTextBox";
            this.IOBUrlTextBox.Size = new System.Drawing.Size(552, 20);
            this.IOBUrlTextBox.TabIndex = 30;
            this.IOBUrlTextBox.Text = "https://ws.b2b.is/Claims/20051201/ClaimService.svc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Web Service URL";
            // 
            // textBoxPublicCert
            // 
            this.textBoxPublicCert.Location = new System.Drawing.Point(15, 80);
            this.textBoxPublicCert.Multiline = true;
            this.textBoxPublicCert.Name = "textBoxPublicCert";
            this.textBoxPublicCert.Size = new System.Drawing.Size(552, 375);
            this.textBoxPublicCert.TabIndex = 32;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(310, 468);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(119, 23);
            this.btnDownload.TabIndex = 33;
            this.btnDownload.Text = "Download Public Key";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(435, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 23);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save to file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "cer";
            this.saveFileDialog1.Filter = "Cer Files | *.cer";
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 503);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.textBoxPublicCert);
            this.Controls.Add(this.IOBUrlTextBox);
            this.Controls.Add(this.label4);
            this.Name = "DownloadForm";
            this.Text = "Download Public Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IOBUrlTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPublicCert;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

