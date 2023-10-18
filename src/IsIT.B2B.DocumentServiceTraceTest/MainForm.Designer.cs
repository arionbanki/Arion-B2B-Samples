namespace IsIT.B2B.DocumentServiceTraceTest
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.webBrowserResponse = new System.Windows.Forms.WebBrowser();
            this.webBrowserRequest = new System.Windows.Forms.WebBrowser();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetDocumentResult = new System.Windows.Forms.Button();
            this.textBoxDocumentId = new System.Windows.Forms.TextBox();
            this.CertificatesCMB = new System.Windows.Forms.ComboBox();
            this.onlineBankingCertificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IOBUrlTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBankingCertificateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Response";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Request";
            // 
            // webBrowserResponse
            // 
            this.webBrowserResponse.Location = new System.Drawing.Point(366, 175);
            this.webBrowserResponse.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserResponse.Name = "webBrowserResponse";
            this.webBrowserResponse.Size = new System.Drawing.Size(330, 308);
            this.webBrowserResponse.TabIndex = 41;
            // 
            // webBrowserRequest
            // 
            this.webBrowserRequest.Location = new System.Drawing.Point(14, 175);
            this.webBrowserRequest.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserRequest.Name = "webBrowserRequest";
            this.webBrowserRequest.Size = new System.Drawing.Size(330, 308);
            this.webBrowserRequest.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetDocumentResult);
            this.groupBox2.Controls.Add(this.textBoxDocumentId);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 68);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GetDocumentResult";
            // 
            // btnGetDocumentResult
            // 
            this.btnGetDocumentResult.Location = new System.Drawing.Point(280, 26);
            this.btnGetDocumentResult.Name = "btnGetDocumentResult";
            this.btnGetDocumentResult.Size = new System.Drawing.Size(75, 23);
            this.btnGetDocumentResult.TabIndex = 1;
            this.btnGetDocumentResult.Text = "Get";
            this.btnGetDocumentResult.UseVisualStyleBackColor = true;
            this.btnGetDocumentResult.Click += new System.EventHandler(this.btnGetDocumentResult_Click);
            // 
            // textBoxDocumentId
            // 
            this.textBoxDocumentId.Location = new System.Drawing.Point(17, 28);
            this.textBoxDocumentId.Name = "textBoxDocumentId";
            this.textBoxDocumentId.Size = new System.Drawing.Size(256, 20);
            this.textBoxDocumentId.TabIndex = 0;
            this.textBoxDocumentId.Text = "e4b081a6-afdd-4f63-bb02-6b6a9f797c74";
            // 
            // CertificatesCMB
            // 
            this.CertificatesCMB.DataSource = this.onlineBankingCertificateBindingSource;
            this.CertificatesCMB.DisplayMember = "DisplayName";
            this.CertificatesCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CertificatesCMB.FormattingEnabled = true;
            this.CertificatesCMB.Location = new System.Drawing.Point(15, 49);
            this.CertificatesCMB.Name = "CertificatesCMB";
            this.CertificatesCMB.Size = new System.Drawing.Size(280, 21);
            this.CertificatesCMB.TabIndex = 58;
            this.CertificatesCMB.ValueMember = "Archived";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Certificate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Username";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(447, 50);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(120, 20);
            this.PasswordTextBox.TabIndex = 62;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(311, 50);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.UserNameTextBox.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "URL:";
            // 
            // IOBUrlTextBox
            // 
            this.IOBUrlTextBox.Location = new System.Drawing.Point(50, 6);
            this.IOBUrlTextBox.Name = "IOBUrlTextBox";
            this.IOBUrlTextBox.Size = new System.Drawing.Size(646, 20);
            this.IOBUrlTextBox.TabIndex = 59;
            this.IOBUrlTextBox.Text = "https://ws.b2b.is/Documents/20130101/DocumentService.svc";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 495);
            this.Controls.Add(this.CertificatesCMB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IOBUrlTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.webBrowserResponse);
            this.Controls.Add(this.webBrowserRequest);
            this.Name = "MainForm";
            this.Text = "DocumentService Trace Example";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBankingCertificateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.WebBrowser webBrowserResponse;
        private System.Windows.Forms.WebBrowser webBrowserRequest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGetDocumentResult;
        private System.Windows.Forms.TextBox textBoxDocumentId;
        private System.Windows.Forms.ComboBox CertificatesCMB;
        private System.Windows.Forms.BindingSource onlineBankingCertificateBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IOBUrlTextBox;
    }
}

