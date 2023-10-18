namespace IsIT.B2B.DocumentsServiceNoConfigTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.lblGetDocumentResult = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetDocumentResult = new System.Windows.Forms.Button();
            this.textBoxDocumentId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IOBUrlTextBox = new System.Windows.Forms.TextBox();
            this.onlineBankingCertificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CertificatesCMB = new System.Windows.Forms.ComboBox();
            this.checkBoxUseProxyforCertDownload = new System.Windows.Forms.CheckBox();
            this.checkBoxUseDefaultProxyForServiceFactory = new System.Windows.Forms.CheckBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBankingCertificateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.resultPictureBox);
            this.groupBox4.Controls.Add(this.lblGetDocumentResult);
            this.groupBox4.Location = new System.Drawing.Point(13, 205);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(725, 55);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result";
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Location = new System.Drawing.Point(13, 21);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(16, 16);
            this.resultPictureBox.TabIndex = 46;
            this.resultPictureBox.TabStop = false;
            // 
            // lblGetDocumentResult
            // 
            this.lblGetDocumentResult.AutoSize = true;
            this.lblGetDocumentResult.Location = new System.Drawing.Point(29, 24);
            this.lblGetDocumentResult.Name = "lblGetDocumentResult";
            this.lblGetDocumentResult.Size = new System.Drawing.Size(0, 13);
            this.lblGetDocumentResult.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetDocumentResult);
            this.groupBox2.Controls.Add(this.textBoxDocumentId);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 68);
            this.groupBox2.TabIndex = 56;
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Certificate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Username";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(444, 58);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(120, 20);
            this.PasswordTextBox.TabIndex = 52;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(308, 58);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.UserNameTextBox.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "URL:";
            // 
            // IOBUrlTextBox
            // 
            this.IOBUrlTextBox.Location = new System.Drawing.Point(47, 14);
            this.IOBUrlTextBox.Name = "IOBUrlTextBox";
            this.IOBUrlTextBox.Size = new System.Drawing.Size(690, 20);
            this.IOBUrlTextBox.TabIndex = 48;
            this.IOBUrlTextBox.Text = "https://ws.b2b.is/Documents/20130101/DocumentService.svc";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "check.png");
            this.imageList1.Images.SetKeyName(1, "error.png");
            this.imageList1.Images.SetKeyName(2, "CopyCode.gif");
            // 
            // CertificatesCMB
            // 
            this.CertificatesCMB.DataSource = this.onlineBankingCertificateBindingSource;
            this.CertificatesCMB.DisplayMember = "DisplayName";
            this.CertificatesCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CertificatesCMB.FormattingEnabled = true;
            this.CertificatesCMB.Location = new System.Drawing.Point(12, 57);
            this.CertificatesCMB.Name = "CertificatesCMB";
            this.CertificatesCMB.Size = new System.Drawing.Size(280, 21);
            this.CertificatesCMB.TabIndex = 32;
            this.CertificatesCMB.ValueMember = "Archived";
            // 
            // checkBoxUseProxyforCertDownload
            // 
            this.checkBoxUseProxyforCertDownload.AutoSize = true;
            this.checkBoxUseProxyforCertDownload.Location = new System.Drawing.Point(12, 85);
            this.checkBoxUseProxyforCertDownload.Name = "checkBoxUseProxyforCertDownload";
            this.checkBoxUseProxyforCertDownload.Size = new System.Drawing.Size(291, 17);
            this.checkBoxUseProxyforCertDownload.TabIndex = 58;
            this.checkBoxUseProxyforCertDownload.Text = "Use Default Proxy Server for Public Certificate download";
            this.checkBoxUseProxyforCertDownload.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseDefaultProxyForServiceFactory
            // 
            this.checkBoxUseDefaultProxyForServiceFactory.AutoSize = true;
            this.checkBoxUseDefaultProxyForServiceFactory.Location = new System.Drawing.Point(12, 108);
            this.checkBoxUseDefaultProxyForServiceFactory.Name = "checkBoxUseDefaultProxyForServiceFactory";
            this.checkBoxUseDefaultProxyForServiceFactory.Size = new System.Drawing.Size(200, 17);
            this.checkBoxUseDefaultProxyForServiceFactory.TabIndex = 59;
            this.checkBoxUseDefaultProxyForServiceFactory.Text = "Use Default Proxy for Service factory";
            this.checkBoxUseDefaultProxyForServiceFactory.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 271);
            this.Controls.Add(this.checkBoxUseDefaultProxyForServiceFactory);
            this.Controls.Add(this.checkBoxUseProxyforCertDownload);
            this.Controls.Add(this.CertificatesCMB);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IOBUrlTextBox);
            this.Name = "MainForm";
            this.Text = "Document Service Example (No endpoint configuration needed)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBankingCertificateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblGetDocumentResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGetDocumentResult;
        private System.Windows.Forms.TextBox textBoxDocumentId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IOBUrlTextBox;
        private System.Windows.Forms.BindingSource onlineBankingCertificateBindingSource;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox CertificatesCMB;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.CheckBox checkBoxUseProxyforCertDownload;
        private System.Windows.Forms.CheckBox checkBoxUseDefaultProxyForServiceFactory;
    }
}

