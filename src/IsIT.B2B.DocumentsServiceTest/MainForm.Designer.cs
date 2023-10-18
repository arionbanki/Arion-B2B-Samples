namespace IsIT.B2B.DocumentsServiceTest
{
    partial class FrmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainForm));
            this.IOBUrlTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTegund = new System.Windows.Forms.ComboBox();
            this.textBoxKennitala = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetDocumentResult = new System.Windows.Forms.Button();
            this.textBoxDocumentId = new System.Windows.Forms.TextBox();
            this.onlineBankingCertificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CertificatesCMB = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblUploadDocumentResult = new System.Windows.Forms.Label();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblGetDocumentResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBankingCertificateBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // IOBUrlTextBox
            // 
            this.IOBUrlTextBox.Location = new System.Drawing.Point(50, 13);
            this.IOBUrlTextBox.Name = "IOBUrlTextBox";
            this.IOBUrlTextBox.Size = new System.Drawing.Size(690, 20);
            this.IOBUrlTextBox.TabIndex = 0;
            this.IOBUrlTextBox.Text = "https://ws.b2b.is/Documents/20130101/DocumentService.svc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Certificate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Username";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(447, 57);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(120, 20);
            this.PasswordTextBox.TabIndex = 38;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(311, 57);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.UserNameTextBox.TabIndex = 37;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxTegund);
            this.groupBox1.Controls.Add(this.textBoxKennitala);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxFileName);
            this.groupBox1.Location = new System.Drawing.Point(15, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 188);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UploadDocument";
            // 
            // comboBoxTegund
            // 
            this.comboBoxTegund.FormattingEnabled = true;
            this.comboBoxTegund.Items.AddRange(new object[] {
            "PW",
            "LS"});
            this.comboBoxTegund.Location = new System.Drawing.Point(80, 122);
            this.comboBoxTegund.Name = "comboBoxTegund";
            this.comboBoxTegund.Size = new System.Drawing.Size(253, 21);
            this.comboBoxTegund.TabIndex = 8;
            // 
            // textBoxKennitala
            // 
            this.textBoxKennitala.Location = new System.Drawing.Point(80, 93);
            this.textBoxKennitala.Name = "textBoxKennitala";
            this.textBoxKennitala.Size = new System.Drawing.Size(253, 20);
            this.textBoxKennitala.TabIndex = 7;
            this.textBoxKennitala.Text = "1234567890";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(80, 64);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(253, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nafn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tegund";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kennitala";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(258, 154);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choose File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(15, 28);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(237, 20);
            this.textBoxFileName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetDocumentResult);
            this.groupBox2.Controls.Add(this.textBoxDocumentId);
            this.groupBox2.Location = new System.Drawing.Point(377, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 188);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GetDocumentResult";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnGetDocumentResult
            // 
            this.btnGetDocumentResult.Location = new System.Drawing.Point(280, 26);
            this.btnGetDocumentResult.Name = "btnGetDocumentResult";
            this.btnGetDocumentResult.Size = new System.Drawing.Size(75, 23);
            this.btnGetDocumentResult.TabIndex = 1;
            this.btnGetDocumentResult.Text = "Get";
            this.btnGetDocumentResult.UseVisualStyleBackColor = true;
            this.btnGetDocumentResult.Click += new System.EventHandler(this.btnGetUploadResult_Click);
            // 
            // textBoxDocumentId
            // 
            this.textBoxDocumentId.Location = new System.Drawing.Point(17, 28);
            this.textBoxDocumentId.Name = "textBoxDocumentId";
            this.textBoxDocumentId.Size = new System.Drawing.Size(256, 20);
            this.textBoxDocumentId.TabIndex = 0;
            // 
            // CertificatesCMB
            // 
            this.CertificatesCMB.DataSource = this.onlineBankingCertificateBindingSource;
            this.CertificatesCMB.DisplayMember = "DisplayName";
            this.CertificatesCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CertificatesCMB.FormattingEnabled = true;
            this.CertificatesCMB.Location = new System.Drawing.Point(15, 56);
            this.CertificatesCMB.Name = "CertificatesCMB";
            this.CertificatesCMB.Size = new System.Drawing.Size(280, 21);
            this.CertificatesCMB.TabIndex = 31;
            this.CertificatesCMB.ValueMember = "Archived";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "check.png");
            this.imageList1.Images.SetKeyName(1, "error.png");
            this.imageList1.Images.SetKeyName(2, "CopyCode.gif");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCopy);
            this.groupBox3.Controls.Add(this.lblUploadDocumentResult);
            this.groupBox3.Controls.Add(this.resultPictureBox);
            this.groupBox3.Location = new System.Drawing.Point(15, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 56);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // btnCopy
            // 
            this.btnCopy.ImageKey = "CopyCode.gif";
            this.btnCopy.ImageList = this.imageList1;
            this.btnCopy.Location = new System.Drawing.Point(296, 18);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(46, 23);
            this.btnCopy.TabIndex = 47;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblUploadDocumentResult
            // 
            this.lblUploadDocumentResult.AutoSize = true;
            this.lblUploadDocumentResult.Location = new System.Drawing.Point(34, 27);
            this.lblUploadDocumentResult.Name = "lblUploadDocumentResult";
            this.lblUploadDocumentResult.Size = new System.Drawing.Size(0, 13);
            this.lblUploadDocumentResult.TabIndex = 46;
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Location = new System.Drawing.Point(12, 25);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(16, 16);
            this.resultPictureBox.TabIndex = 45;
            this.resultPictureBox.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblGetDocumentResult);
            this.groupBox4.Location = new System.Drawing.Point(377, 291);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(363, 55);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result";
            // 
            // lblGetDocumentResult
            // 
            this.lblGetDocumentResult.AutoSize = true;
            this.lblGetDocumentResult.Location = new System.Drawing.Point(7, 21);
            this.lblGetDocumentResult.Name = "lblGetDocumentResult";
            this.lblGetDocumentResult.Size = new System.Drawing.Size(0, 13);
            this.lblGetDocumentResult.TabIndex = 0;
            // 
            // FrmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 358);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CertificatesCMB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IOBUrlTextBox);
            this.Name = "FrmMainForm";
            this.Text = "Rafræn skjöl";
            this.Load += new System.EventHandler(this.FrmMainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBankingCertificateBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IOBUrlTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource onlineBankingCertificateBindingSource;
        private System.Windows.Forms.ComboBox CertificatesCMB;
        private System.Windows.Forms.ComboBox comboBoxTegund;
        private System.Windows.Forms.TextBox textBoxKennitala;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.Label lblUploadDocumentResult;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnGetDocumentResult;
        private System.Windows.Forms.TextBox textBoxDocumentId;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblGetDocumentResult;
    }
}

