namespace IsIT.B2B.ForeignStatementServiceTest
{
    partial class ForeignStatementsForm
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
            this.onlineBankingCertificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewStatements = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNxtPage = new System.Windows.Forms.Button();
            this.btnFirstPAge = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.treeViewResult = new System.Windows.Forms.TreeView();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.IOBUrlTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CertificatesCMB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBankingCertificateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatements)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.groupBoxDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(711, 103);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(178, 26);
            this.PasswordTextBox.TabIndex = 59;
            // 
            // dataGridViewStatements
            // 
            this.dataGridViewStatements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatements.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewStatements.Location = new System.Drawing.Point(12, 29);
            this.dataGridViewStatements.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewStatements.Name = "dataGridViewStatements";
            this.dataGridViewStatements.RowHeadersWidth = 102;
            this.dataGridViewStatements.Size = new System.Drawing.Size(1600, 349);
            this.dataGridViewStatements.TabIndex = 0;
            this.dataGridViewStatements.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTransactions_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(290, 52);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(289, 48);
            this.toolStripMenuItem1.Text = "Open Swift file";
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
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(26, 38);
            this.lblAccountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(0, 20);
            this.lblAccountNumber.TabIndex = 3;
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
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.dateTimePickerTo);
            this.groupBoxDetails.Controls.Add(this.label7);
            this.groupBoxDetails.Controls.Add(this.label6);
            this.groupBoxDetails.Controls.Add(this.dateTimePickerFrom);
            this.groupBoxDetails.Controls.Add(this.lblAccountNumber);
            this.groupBoxDetails.Controls.Add(this.groupBox2);
            this.groupBoxDetails.Controls.Add(this.pictureBoxLoading);
            this.groupBoxDetails.Location = new System.Drawing.Point(58, 349);
            this.groupBoxDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDetails.Size = new System.Drawing.Size(1665, 654);
            this.groupBoxDetails.TabIndex = 54;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            this.groupBoxDetails.Visible = false;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(387, 98);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(298, 26);
            this.dateTimePickerTo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "From";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(32, 98);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(298, 26);
            this.dateTimePickerFrom.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPageInfo);
            this.groupBox2.Controls.Add(this.panelNavigation);
            this.groupBox2.Controls.Add(this.dataGridViewStatements);
            this.groupBox2.Location = new System.Drawing.Point(30, 154);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1622, 488);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statements";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(711, 305);
            this.btnGet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(180, 35);
            this.btnGet.TabIndex = 53;
            this.btnGet.Text = "GetForeignAccounts";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.treeViewResult);
            this.groupBox1.Location = new System.Drawing.Point(900, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(828, 334);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Certificate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Username";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(507, 103);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(178, 26);
            this.UserNameTextBox.TabIndex = 58;
            // 
            // IOBUrlTextBox
            // 
            this.IOBUrlTextBox.Location = new System.Drawing.Point(63, 26);
            this.IOBUrlTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IOBUrlTextBox.Name = "IOBUrlTextBox";
            this.IOBUrlTextBox.Size = new System.Drawing.Size(826, 26);
            this.IOBUrlTextBox.TabIndex = 56;
            this.IOBUrlTextBox.Text = "https://ws.b2b.is/ForeignPayments/20150801/ForeignStatementService.svc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Web Service URL";
            // 
            // CertificatesCMB
            // 
            this.CertificatesCMB.DataSource = this.onlineBankingCertificateBindingSource;
            this.CertificatesCMB.DisplayMember = "DisplayName";
            this.CertificatesCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CertificatesCMB.FormattingEnabled = true;
            this.CertificatesCMB.Location = new System.Drawing.Point(63, 103);
            this.CertificatesCMB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CertificatesCMB.Name = "CertificatesCMB";
            this.CertificatesCMB.Size = new System.Drawing.Size(418, 28);
            this.CertificatesCMB.TabIndex = 55;
            this.CertificatesCMB.ValueMember = "Archived";
            // 
            // ForeignStatementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1742, 1003);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.IOBUrlTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CertificatesCMB);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ForeignStatementsForm";
            this.Text = "ForeignStatements Service Demo";
            this.Load += new System.EventHandler(this.ForeignStatementsForm_Load);
            this.Shown += new System.EventHandler(this.ForeignStatementsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.onlineBankingCertificateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatements)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource onlineBankingCertificateBindingSource;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.DataGridView dataGridViewStatements;
        private System.Windows.Forms.Button btnNxtPage;
        private System.Windows.Forms.Button btnFirstPAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TreeView treeViewResult;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox IOBUrlTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CertificatesCMB;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

