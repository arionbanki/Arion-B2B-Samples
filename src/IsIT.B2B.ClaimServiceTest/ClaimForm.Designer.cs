namespace IsIT.B2B.ClaimServiceTest
{
    partial class ClaimForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._btnQueryClaimSearch = new System.Windows.Forms.Button();
            this._txtQueryClaimClaimant = new System.Windows.Forms.TextBox();
            this._nupQueryClaimEntryTo = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this._nupQueryClaimEntryFrom = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this._dtpQueryClaimDateTo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this._dtpQueryClaimDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this._cmbQueryClaimReferenceDate = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this._cmbQueryClaimStatus = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this._txtQueryClaimIdentifier = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this._txtQueryClaimPayor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._dgvQueriedClaims = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CertificatesCMB = new System.Windows.Forms.ComboBox();
            this.onlineBankingCertificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.IOBUrlTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxUseProxyforCertDownload = new System.Windows.Forms.CheckBox();
            this.checkBoxUseDefaultProxyForServiceFactory = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._txtQueryClaimClaimantSingle = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this._dtpQueryClaimDueDateSingle = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this._txtQueryClaimAccountSingle = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this._btnQueryClaimSingleSearch = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nupQueryClaimEntryTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nupQueryClaimEntryFrom)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvQueriedClaims)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBankingCertificateBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._btnQueryClaimSearch);
            this.groupBox3.Controls.Add(this._txtQueryClaimClaimant);
            this.groupBox3.Controls.Add(this._nupQueryClaimEntryTo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this._nupQueryClaimEntryFrom);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this._dtpQueryClaimDateTo);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this._dtpQueryClaimDateFrom);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this._cmbQueryClaimReferenceDate);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this._cmbQueryClaimStatus);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this._txtQueryClaimIdentifier);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this._txtQueryClaimPayor);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(15, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 317);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Claims";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // _btnQueryClaimSearch
            // 
            this._btnQueryClaimSearch.Location = new System.Drawing.Point(226, 282);
            this._btnQueryClaimSearch.Name = "_btnQueryClaimSearch";
            this._btnQueryClaimSearch.Size = new System.Drawing.Size(75, 23);
            this._btnQueryClaimSearch.TabIndex = 12;
            this._btnQueryClaimSearch.Text = "Search";
            this._btnQueryClaimSearch.UseVisualStyleBackColor = true;
            this._btnQueryClaimSearch.Click += new System.EventHandler(this._btnQueryClaimSearch_Click);
            // 
            // _txtQueryClaimClaimant
            // 
            this._txtQueryClaimClaimant.Location = new System.Drawing.Point(112, 21);
            this._txtQueryClaimClaimant.Name = "_txtQueryClaimClaimant";
            this._txtQueryClaimClaimant.Size = new System.Drawing.Size(189, 20);
            this._txtQueryClaimClaimant.TabIndex = 1;
            // 
            // _nupQueryClaimEntryTo
            // 
            this._nupQueryClaimEntryTo.Location = new System.Drawing.Point(252, 250);
            this._nupQueryClaimEntryTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nupQueryClaimEntryTo.Name = "_nupQueryClaimEntryTo";
            this._nupQueryClaimEntryTo.Size = new System.Drawing.Size(49, 20);
            this._nupQueryClaimEntryTo.TabIndex = 6;
            this._nupQueryClaimEntryTo.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Claimant";
            // 
            // _nupQueryClaimEntryFrom
            // 
            this._nupQueryClaimEntryFrom.Location = new System.Drawing.Point(112, 250);
            this._nupQueryClaimEntryFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nupQueryClaimEntryFrom.Name = "_nupQueryClaimEntryFrom";
            this._nupQueryClaimEntryFrom.Size = new System.Drawing.Size(49, 20);
            this._nupQueryClaimEntryFrom.TabIndex = 5;
            this._nupQueryClaimEntryFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Identifier";
            // 
            // _dtpQueryClaimDateTo
            // 
            this._dtpQueryClaimDateTo.Location = new System.Drawing.Point(112, 218);
            this._dtpQueryClaimDateTo.Name = "_dtpQueryClaimDateTo";
            this._dtpQueryClaimDateTo.Size = new System.Drawing.Size(189, 20);
            this._dtpQueryClaimDateTo.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Payor";
            // 
            // _dtpQueryClaimDateFrom
            // 
            this._dtpQueryClaimDateFrom.Location = new System.Drawing.Point(112, 181);
            this._dtpQueryClaimDateFrom.Name = "_dtpQueryClaimDateFrom";
            this._dtpQueryClaimDateFrom.Size = new System.Drawing.Size(189, 20);
            this._dtpQueryClaimDateFrom.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Claim Status";
            // 
            // _cmbQueryClaimReferenceDate
            // 
            this._cmbQueryClaimReferenceDate.FormattingEnabled = true;
            this._cmbQueryClaimReferenceDate.Location = new System.Drawing.Point(112, 148);
            this._cmbQueryClaimReferenceDate.Name = "_cmbQueryClaimReferenceDate";
            this._cmbQueryClaimReferenceDate.Size = new System.Drawing.Size(189, 21);
            this._cmbQueryClaimReferenceDate.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Entry From";
            // 
            // _cmbQueryClaimStatus
            // 
            this._cmbQueryClaimStatus.FormattingEnabled = true;
            this._cmbQueryClaimStatus.Location = new System.Drawing.Point(112, 117);
            this._cmbQueryClaimStatus.Name = "_cmbQueryClaimStatus";
            this._cmbQueryClaimStatus.Size = new System.Drawing.Size(189, 21);
            this._cmbQueryClaimStatus.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(190, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Entry To";
            // 
            // _txtQueryClaimIdentifier
            // 
            this._txtQueryClaimIdentifier.Location = new System.Drawing.Point(112, 53);
            this._txtQueryClaimIdentifier.Name = "_txtQueryClaimIdentifier";
            this._txtQueryClaimIdentifier.Size = new System.Drawing.Size(189, 20);
            this._txtQueryClaimIdentifier.TabIndex = 2;
            this._txtQueryClaimIdentifier.Text = "101";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Date From";
            // 
            // _txtQueryClaimPayor
            // 
            this._txtQueryClaimPayor.Location = new System.Drawing.Point(112, 85);
            this._txtQueryClaimPayor.Name = "_txtQueryClaimPayor";
            this._txtQueryClaimPayor.Size = new System.Drawing.Size(189, 20);
            this._txtQueryClaimPayor.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Reference Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Date To";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._dgvQueriedClaims);
            this.groupBox4.Location = new System.Drawing.Point(15, 485);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox4.Size = new System.Drawing.Size(692, 199);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results";
            // 
            // _dgvQueriedClaims
            // 
            this._dgvQueriedClaims.AllowUserToAddRows = false;
            this._dgvQueriedClaims.AllowUserToDeleteRows = false;
            this._dgvQueriedClaims.AllowUserToOrderColumns = true;
            this._dgvQueriedClaims.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgvQueriedClaims.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvQueriedClaims.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._dgvQueriedClaims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dgvQueriedClaims.DefaultCellStyle = dataGridViewCellStyle2;
            this._dgvQueriedClaims.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgvQueriedClaims.Location = new System.Drawing.Point(20, 33);
            this._dgvQueriedClaims.Name = "_dgvQueriedClaims";
            this._dgvQueriedClaims.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvQueriedClaims.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._dgvQueriedClaims.Size = new System.Drawing.Size(652, 146);
            this._dgvQueriedClaims.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Certificate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Username";
            // 
            // CertificatesCMB
            // 
            this.CertificatesCMB.DataSource = this.onlineBankingCertificateBindingSource;
            this.CertificatesCMB.DisplayMember = "DisplayName";
            this.CertificatesCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CertificatesCMB.FormattingEnabled = true;
            this.CertificatesCMB.Location = new System.Drawing.Point(15, 75);
            this.CertificatesCMB.Name = "CertificatesCMB";
            this.CertificatesCMB.Size = new System.Drawing.Size(280, 21);
            this.CertificatesCMB.TabIndex = 30;
            this.CertificatesCMB.ValueMember = "Archived";
            this.CertificatesCMB.SelectedIndexChanged += new System.EventHandler(this.CertificatesCMB_SelectedIndexChanged);
            // 
            // onlineBankingCertificateBindingSource
            // 
            this.onlineBankingCertificateBindingSource.DataSource = typeof(IsIT.B2B.Common.Security.OnlineBankingCertificate);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(447, 75);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(120, 20);
            this.PasswordTextBox.TabIndex = 32;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(311, 75);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.UserNameTextBox.TabIndex = 31;
            // 
            // IOBUrlTextBox
            // 
            this.IOBUrlTextBox.Location = new System.Drawing.Point(15, 25);
            this.IOBUrlTextBox.Name = "IOBUrlTextBox";
            this.IOBUrlTextBox.Size = new System.Drawing.Size(552, 20);
            this.IOBUrlTextBox.TabIndex = 28;
            this.IOBUrlTextBox.Text = "https://ws.b2b.is/Claims/20131015/ClaimService.svc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Web Service URL";
            // 
            // checkBoxUseProxyforCertDownload
            // 
            this.checkBoxUseProxyforCertDownload.AutoSize = true;
            this.checkBoxUseProxyforCertDownload.Location = new System.Drawing.Point(15, 116);
            this.checkBoxUseProxyforCertDownload.Name = "checkBoxUseProxyforCertDownload";
            this.checkBoxUseProxyforCertDownload.Size = new System.Drawing.Size(291, 17);
            this.checkBoxUseProxyforCertDownload.TabIndex = 59;
            this.checkBoxUseProxyforCertDownload.Text = "Use Default Proxy Server for Public Certificate download";
            this.checkBoxUseProxyforCertDownload.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseDefaultProxyForServiceFactory
            // 
            this.checkBoxUseDefaultProxyForServiceFactory.AutoSize = true;
            this.checkBoxUseDefaultProxyForServiceFactory.Location = new System.Drawing.Point(15, 139);
            this.checkBoxUseDefaultProxyForServiceFactory.Name = "checkBoxUseDefaultProxyForServiceFactory";
            this.checkBoxUseDefaultProxyForServiceFactory.Size = new System.Drawing.Size(200, 17);
            this.checkBoxUseDefaultProxyForServiceFactory.TabIndex = 60;
            this.checkBoxUseDefaultProxyForServiceFactory.Text = "Use Default Proxy for Service factory";
            this.checkBoxUseDefaultProxyForServiceFactory.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._txtQueryClaimClaimantSingle);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this._dtpQueryClaimDueDateSingle);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this._txtQueryClaimAccountSingle);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this._btnQueryClaimSingleSearch);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Location = new System.Drawing.Point(357, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 141);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Single Claim";
            // 
            // _txtQueryClaimClaimantSingle
            // 
            this._txtQueryClaimClaimantSingle.Location = new System.Drawing.Point(108, 21);
            this._txtQueryClaimClaimantSingle.Name = "_txtQueryClaimClaimantSingle";
            this._txtQueryClaimClaimantSingle.Size = new System.Drawing.Size(199, 20);
            this._txtQueryClaimClaimantSingle.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(231, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "( E.g. 032466123456 )";
            // 
            // _dtpQueryClaimDueDateSingle
            // 
            this._dtpQueryClaimDueDateSingle.Location = new System.Drawing.Point(108, 77);
            this._dtpQueryClaimDueDateSingle.Name = "_dtpQueryClaimDueDateSingle";
            this._dtpQueryClaimDueDateSingle.Size = new System.Drawing.Size(199, 20);
            this._dtpQueryClaimDueDateSingle.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Account";
            // 
            // _txtQueryClaimAccountSingle
            // 
            this._txtQueryClaimAccountSingle.Location = new System.Drawing.Point(108, 47);
            this._txtQueryClaimAccountSingle.Name = "_txtQueryClaimAccountSingle";
            this._txtQueryClaimAccountSingle.Size = new System.Drawing.Size(117, 20);
            this._txtQueryClaimAccountSingle.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "DueDate";
            // 
            // _btnQueryClaimSingleSearch
            // 
            this._btnQueryClaimSingleSearch.Location = new System.Drawing.Point(234, 106);
            this._btnQueryClaimSingleSearch.Name = "_btnQueryClaimSingleSearch";
            this._btnQueryClaimSingleSearch.Size = new System.Drawing.Size(75, 23);
            this._btnQueryClaimSingleSearch.TabIndex = 12;
            this._btnQueryClaimSingleSearch.Text = "Search";
            this._btnQueryClaimSingleSearch.UseVisualStyleBackColor = true;
            this._btnQueryClaimSingleSearch.Click += new System.EventHandler(this._btnQueryClaimSingleSearch_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(26, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Claimant";
            // 
            // ClaimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 699);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxUseDefaultProxyForServiceFactory);
            this.Controls.Add(this.checkBoxUseProxyforCertDownload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CertificatesCMB);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.IOBUrlTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "ClaimForm";
            this.Text = "Claims Sample Client";
            this.Load += new System.EventHandler(this.ClaimForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nupQueryClaimEntryTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nupQueryClaimEntryFrom)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvQueriedClaims)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBankingCertificateBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button _btnQueryClaimSearch;
        private System.Windows.Forms.TextBox _txtQueryClaimClaimant;
        private System.Windows.Forms.NumericUpDown _nupQueryClaimEntryTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown _nupQueryClaimEntryFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker _dtpQueryClaimDateTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker _dtpQueryClaimDateFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox _cmbQueryClaimReferenceDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox _cmbQueryClaimStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox _txtQueryClaimIdentifier;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox _txtQueryClaimPayor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView _dgvQueriedClaims;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CertificatesCMB;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox IOBUrlTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource onlineBankingCertificateBindingSource;
        private System.Windows.Forms.CheckBox checkBoxUseProxyforCertDownload;
        private System.Windows.Forms.CheckBox checkBoxUseDefaultProxyForServiceFactory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _txtQueryClaimClaimantSingle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker _dtpQueryClaimDueDateSingle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox _txtQueryClaimAccountSingle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button _btnQueryClaimSingleSearch;
        private System.Windows.Forms.Label label20;
    }
}

