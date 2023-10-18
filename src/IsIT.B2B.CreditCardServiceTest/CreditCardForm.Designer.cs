namespace IsIT.B2B.CreditCardServiceTest
{
    partial class CreditCardForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.treeViewResult = new System.Windows.Forms.TreeView();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.lblCardHolderId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnNxtPage = new System.Windows.Forms.Button();
            this.btnFirstPAge = new System.Windows.Forms.Button();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.lblCardHolderName = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.IOBUrlTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.onlineBankingCertificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CertificatesCMB = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBankingCertificateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.treeViewResult);
            this.groupBox1.Location = new System.Drawing.Point(860, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(828, 334);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "List";
            // 
            // treeViewResult
            // 
            this.treeViewResult.Location = new System.Drawing.Point(24, 52);
            this.treeViewResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeViewResult.Name = "treeViewResult";
            this.treeViewResult.Size = new System.Drawing.Size(788, 255);
            this.treeViewResult.TabIndex = 2;
            this.treeViewResult.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewResult_AfterSelect);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.lblCardHolderId);
            this.groupBoxDetails.Controls.Add(this.groupBox2);
            this.groupBoxDetails.Controls.Add(this.pictureBoxLoading);
            this.groupBoxDetails.Controls.Add(this.lblCardHolderName);
            this.groupBoxDetails.Location = new System.Drawing.Point(18, 362);
            this.groupBoxDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDetails.Size = new System.Drawing.Size(1665, 654);
            this.groupBoxDetails.TabIndex = 15;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            this.groupBoxDetails.Visible = false;
            this.groupBoxDetails.Enter += new System.EventHandler(this.groupBoxDetails_Enter);
            // 
            // lblCardHolderId
            // 
            this.lblCardHolderId.AutoSize = true;
            this.lblCardHolderId.Location = new System.Drawing.Point(26, 38);
            this.lblCardHolderId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardHolderId.Name = "lblCardHolderId";
            this.lblCardHolderId.Size = new System.Drawing.Size(0, 20);
            this.lblCardHolderId.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPageInfo);
            this.groupBox2.Controls.Add(this.panelNavigation);
            this.groupBox2.Controls.Add(this.dataGridViewTransactions);
            this.groupBox2.Location = new System.Drawing.Point(30, 154);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1622, 488);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transactions";
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Location = new System.Drawing.Point(24, 426);
            this.lblPageInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(0, 20);
            this.lblPageInfo.TabIndex = 20;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.White;
            this.panelNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavigation.Controls.Add(this.button1);
            this.panelNavigation.Controls.Add(this.btnPrevPage);
            this.panelNavigation.Controls.Add(this.btnLastPage);
            this.panelNavigation.Controls.Add(this.btnNxtPage);
            this.panelNavigation.Controls.Add(this.btnFirstPAge);
            this.panelNavigation.Location = new System.Drawing.Point(324, 406);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(914, 71);
            this.panelNavigation.TabIndex = 19;
            this.panelNavigation.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(698, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrevPage.Location = new System.Drawing.Point(404, 20);
            this.btnPrevPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(112, 35);
            this.btnPrevPage.TabIndex = 13;
            this.btnPrevPage.Text = "Previous Page";
            this.btnPrevPage.UseVisualStyleBackColor = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLastPage.Location = new System.Drawing.Point(554, 20);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(112, 35);
            this.btnLastPage.TabIndex = 14;
            this.btnLastPage.Text = "Last Page";
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNxtPage
            // 
            this.btnNxtPage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNxtPage.Location = new System.Drawing.Point(254, 18);
            this.btnNxtPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNxtPage.Name = "btnNxtPage";
            this.btnNxtPage.Size = new System.Drawing.Size(112, 35);
            this.btnNxtPage.TabIndex = 11;
            this.btnNxtPage.Text = "Next page";
            this.btnNxtPage.UseVisualStyleBackColor = false;
            this.btnNxtPage.Click += new System.EventHandler(this.btnNxtPage_Click);
            // 
            // btnFirstPAge
            // 
            this.btnFirstPAge.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFirstPAge.Location = new System.Drawing.Point(104, 18);
            this.btnFirstPAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFirstPAge.Name = "btnFirstPAge";
            this.btnFirstPAge.Size = new System.Drawing.Size(112, 35);
            this.btnFirstPAge.TabIndex = 12;
            this.btnFirstPAge.Text = "First Page";
            this.btnFirstPAge.UseVisualStyleBackColor = false;
            this.btnFirstPAge.Click += new System.EventHandler(this.btnFirstPAge_Click);
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(12, 29);
            this.dataGridViewTransactions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.RowHeadersWidth = 102;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(1600, 349);
            this.dataGridViewTransactions.TabIndex = 0;
            this.dataGridViewTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransactions_CellContentClick);
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Enabled = false;
            this.pictureBoxLoading.Location = new System.Drawing.Point(784, 95);
            this.pictureBoxLoading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLoading.TabIndex = 1;
            this.pictureBoxLoading.TabStop = false;
            // 
            // lblCardHolderName
            // 
            this.lblCardHolderName.AutoSize = true;
            this.lblCardHolderName.Location = new System.Drawing.Point(26, 74);
            this.lblCardHolderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardHolderName.Name = "lblCardHolderName";
            this.lblCardHolderName.Size = new System.Drawing.Size(0, 20);
            this.lblCardHolderName.TabIndex = 0;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(720, 317);
            this.btnGet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(130, 35);
            this.btnGet.TabIndex = 13;
            this.btnGet.Text = "GetCreditCards";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Certificate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(666, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Username";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(670, 115);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(178, 26);
            this.PasswordTextBox.TabIndex = 48;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(466, 115);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(178, 26);
            this.UserNameTextBox.TabIndex = 47;
            // 
            // IOBUrlTextBox
            // 
            this.IOBUrlTextBox.Location = new System.Drawing.Point(22, 38);
            this.IOBUrlTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IOBUrlTextBox.Name = "IOBUrlTextBox";
            this.IOBUrlTextBox.Size = new System.Drawing.Size(826, 26);
            this.IOBUrlTextBox.TabIndex = 45;
            this.IOBUrlTextBox.Text = "https://ws.b2b.is/CreditCards/20130901/CreditCardService.svc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Web Service URL";
            // 
            // CertificatesCMB
            // 
            this.CertificatesCMB.DataSource = this.onlineBankingCertificateBindingSource;
            this.CertificatesCMB.DisplayMember = "DisplayName";
            this.CertificatesCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CertificatesCMB.FormattingEnabled = true;
            this.CertificatesCMB.Location = new System.Drawing.Point(22, 115);
            this.CertificatesCMB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CertificatesCMB.Name = "CertificatesCMB";
            this.CertificatesCMB.Size = new System.Drawing.Size(418, 28);
            this.CertificatesCMB.TabIndex = 44;
            this.CertificatesCMB.ValueMember = "Archived";
            // 
            // CreditCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 1022);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.IOBUrlTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CertificatesCMB);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreditCardForm";
            this.Text = "CreditCard Service Demo";
            this.Load += new System.EventHandler(this.CreditCardForm_Load);
            this.Shown += new System.EventHandler(this.CreditCardForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBankingCertificateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TreeView treeViewResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox IOBUrlTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource onlineBankingCertificateBindingSource;
        private System.Windows.Forms.ComboBox CertificatesCMB;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCardHolderName;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.Label lblCardHolderId;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnNxtPage;
        private System.Windows.Forms.Button btnFirstPAge;
        private System.Windows.Forms.Label lblPageInfo;
    }
}

