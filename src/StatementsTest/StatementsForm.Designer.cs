namespace IsIT.B2B.StatementsTest
{
    partial class StatementsForm
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
            this.currencyRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlineBankingCertificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IOBUrlTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.currencyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customsRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.exchangeRateButton = new System.Windows.Forms.Button();
            this.CertificatesCMB = new System.Windows.Forms.ComboBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.currencyRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBankingCertificateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // currencyRateBindingSource
            // 
            this.currencyRateBindingSource.DataSource = typeof(IsIT.B2B.StatementsTest.StatementsService.CurrencyRate);
            // 
            // onlineBankingCertificateBindingSource
            // 
            this.onlineBankingCertificateBindingSource.DataSource = typeof(IsIT.B2B.Common.Security.OnlineBankingCertificate);
            // 
            // IOBUrlTextBox
            // 
            this.IOBUrlTextBox.Location = new System.Drawing.Point(15, 25);
            this.IOBUrlTextBox.Name = "IOBUrlTextBox";
            this.IOBUrlTextBox.Size = new System.Drawing.Size(655, 20);
            this.IOBUrlTextBox.TabIndex = 19;
            this.IOBUrlTextBox.Text = global::IsIT.B2B.StatementsTest.Properties.Settings.Default.IsIT_B2B_StatementsTest_StatementsService_IcelandicOnlineBankingStatementsService;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Web Service URL";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currencyCodeDataGridViewTextBoxColumn,
            this.buyingRateDataGridViewTextBoxColumn,
            this.sellingRateDataGridViewTextBoxColumn,
            this.customsRateDataGridViewTextBoxColumn,
            this.timeStampDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.currencyRateBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(655, 378);
            this.dataGridView1.TabIndex = 24;
            // 
            // currencyCodeDataGridViewTextBoxColumn
            // 
            this.currencyCodeDataGridViewTextBoxColumn.DataPropertyName = "CurrencyCode";
            this.currencyCodeDataGridViewTextBoxColumn.HeaderText = "CurrencyCode";
            this.currencyCodeDataGridViewTextBoxColumn.Name = "currencyCodeDataGridViewTextBoxColumn";
            this.currencyCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buyingRateDataGridViewTextBoxColumn
            // 
            this.buyingRateDataGridViewTextBoxColumn.DataPropertyName = "BuyingRate";
            this.buyingRateDataGridViewTextBoxColumn.HeaderText = "BuyingRate";
            this.buyingRateDataGridViewTextBoxColumn.Name = "buyingRateDataGridViewTextBoxColumn";
            this.buyingRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellingRateDataGridViewTextBoxColumn
            // 
            this.sellingRateDataGridViewTextBoxColumn.DataPropertyName = "SellingRate";
            this.sellingRateDataGridViewTextBoxColumn.HeaderText = "SellingRate";
            this.sellingRateDataGridViewTextBoxColumn.Name = "sellingRateDataGridViewTextBoxColumn";
            this.sellingRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customsRateDataGridViewTextBoxColumn
            // 
            this.customsRateDataGridViewTextBoxColumn.DataPropertyName = "CustomsRate";
            this.customsRateDataGridViewTextBoxColumn.HeaderText = "CustomsRate";
            this.customsRateDataGridViewTextBoxColumn.Name = "customsRateDataGridViewTextBoxColumn";
            this.customsRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeStampDataGridViewTextBoxColumn
            // 
            this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
            this.timeStampDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeStampDataGridViewTextBoxColumn.Width = 252;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Certificate";
            // 
            // exchangeRateButton
            // 
            this.exchangeRateButton.Location = new System.Drawing.Point(553, 69);
            this.exchangeRateButton.Name = "exchangeRateButton";
            this.exchangeRateButton.Size = new System.Drawing.Size(117, 21);
            this.exchangeRateButton.TabIndex = 23;
            this.exchangeRateButton.Text = "Get Exchange Rate";
            this.exchangeRateButton.UseVisualStyleBackColor = true;
            this.exchangeRateButton.Click += new System.EventHandler(this.ExchangeRateButton_Click);
            // 
            // CertificatesCMB
            // 
            this.CertificatesCMB.DataSource = this.onlineBankingCertificateBindingSource;
            this.CertificatesCMB.DisplayMember = "DisplayName";
            this.CertificatesCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CertificatesCMB.FormattingEnabled = true;
            this.CertificatesCMB.Location = new System.Drawing.Point(15, 68);
            this.CertificatesCMB.Name = "CertificatesCMB";
            this.CertificatesCMB.Size = new System.Drawing.Size(280, 21);
            this.CertificatesCMB.TabIndex = 20;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(427, 69);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(120, 20);
            this.PasswordTextBox.TabIndex = 22;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(301, 69);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.UserNameTextBox.TabIndex = 21;
            // 
            // StatementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 507);
            this.Controls.Add(this.IOBUrlTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exchangeRateButton);
            this.Controls.Add(this.CertificatesCMB);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Name = "StatementsForm";
            this.Text = "Arion banki  B2B-Statements Sample";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currencyRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBankingCertificateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource currencyRateBindingSource;
        private System.Windows.Forms.BindingSource onlineBankingCertificateBindingSource;
        private System.Windows.Forms.TextBox IOBUrlTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customsRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exchangeRateButton;
        private System.Windows.Forms.ComboBox CertificatesCMB;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
    }
}