namespace IsIT.B2B.DoPaymentTest
{
    partial class PaymentResponseForm
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
            this.paymentsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentResultDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._cmbDataErroredPaymentIn = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._cmbDataTransfer = new System.Windows.Forms.DataGridView();
            this.accountOwnerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._cmbDataStatus = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfPaymentSpecifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._cmbDataErrors = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentIn = new System.Windows.Forms.DataGridViewLinkColumn();
            this._cmbDataSuccess = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewLinkColumn2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ErroredTransfer = new System.Windows.Forms.DataGridViewLinkColumn();
            this.SuccessfulTransfer = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentResultDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmbDataErroredPaymentIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmbDataTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmbDataStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmbDataErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmbDataSuccess)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentsResultBindingSource
            // 
            this.paymentsResultBindingSource.DataSource = typeof(IsIT.B2B.DoPaymentTest.PaymentsService.PaymentsResult);
            // 
            // paymentResultDetailsBindingSource
            // 
            this.paymentResultDetailsBindingSource.DataSource = typeof(IsIT.B2B.DoPaymentTest.PaymentsService.PaymentResultDetails);
            // 
            // paymentInBindingSource
            // 
            this.paymentInBindingSource.DataSource = typeof(IsIT.B2B.DoPaymentTest.PaymentsService.PaymentIn);
            // 
            // errorBindingSource
            // 
            this.errorBindingSource.DataSource = typeof(IsIT.B2B.DoPaymentTest.PaymentsService.Error);
            // 
            // errorsBindingSource
            // 
            this.errorsBindingSource.DataMember = "Errors";
            this.errorsBindingSource.DataSource = this.paymentsResultBindingSource;
            // 
            // transferBindingSource
            // 
            this.transferBindingSource.DataSource = typeof(IsIT.B2B.DoPaymentTest.PaymentsService.Transfer);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "PaymentIn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Transfer";
            // 
            // _cmbDataErroredPaymentIn
            // 
            this._cmbDataErroredPaymentIn.AllowUserToAddRows = false;
            this._cmbDataErroredPaymentIn.AllowUserToDeleteRows = false;
            this._cmbDataErroredPaymentIn.AllowUserToResizeRows = false;
            this._cmbDataErroredPaymentIn.AutoGenerateColumns = false;
            this._cmbDataErroredPaymentIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._cmbDataErroredPaymentIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn1,
            this.amountDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1,
            this.ErroredTransfer});
            this._cmbDataErroredPaymentIn.DataSource = this.paymentInBindingSource;
            this._cmbDataErroredPaymentIn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._cmbDataErroredPaymentIn.Location = new System.Drawing.Point(12, 402);
            this._cmbDataErroredPaymentIn.MultiSelect = false;
            this._cmbDataErroredPaymentIn.Name = "_cmbDataErroredPaymentIn";
            this._cmbDataErroredPaymentIn.ReadOnly = true;
            this._cmbDataErroredPaymentIn.RowHeadersVisible = false;
            this._cmbDataErroredPaymentIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._cmbDataErroredPaymentIn.ShowEditingIcon = false;
            this._cmbDataErroredPaymentIn.Size = new System.Drawing.Size(504, 110);
            this._cmbDataErroredPaymentIn.TabIndex = 15;
            this._cmbDataErroredPaymentIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataErroredPaymentIn_CellContentClick);
            // 
            // bookingIDDataGridViewTextBoxColumn1
            // 
            this.bookingIDDataGridViewTextBoxColumn1.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn1.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn1.Name = "bookingIDDataGridViewTextBoxColumn1";
            this.bookingIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            this.amountDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn1.Width = 200;
            // 
            // _cmbDataTransfer
            // 
            this._cmbDataTransfer.AllowUserToAddRows = false;
            this._cmbDataTransfer.AllowUserToDeleteRows = false;
            this._cmbDataTransfer.AllowUserToResizeRows = false;
            this._cmbDataTransfer.AutoGenerateColumns = false;
            this._cmbDataTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._cmbDataTransfer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountOwnerIDDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn,
            this.billNumberDataGridViewTextBoxColumn,
            this.categoryCodeDataGridViewTextBoxColumn,
            this.referenceDataGridViewTextBoxColumn});
            this._cmbDataTransfer.DataSource = this.transferBindingSource;
            this._cmbDataTransfer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._cmbDataTransfer.Location = new System.Drawing.Point(12, 546);
            this._cmbDataTransfer.MultiSelect = false;
            this._cmbDataTransfer.Name = "_cmbDataTransfer";
            this._cmbDataTransfer.ReadOnly = true;
            this._cmbDataTransfer.RowHeadersVisible = false;
            this._cmbDataTransfer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._cmbDataTransfer.ShowEditingIcon = false;
            this._cmbDataTransfer.Size = new System.Drawing.Size(504, 110);
            this._cmbDataTransfer.TabIndex = 14;
            // 
            // accountOwnerIDDataGridViewTextBoxColumn
            // 
            this.accountOwnerIDDataGridViewTextBoxColumn.DataPropertyName = "AccountOwnerID";
            this.accountOwnerIDDataGridViewTextBoxColumn.HeaderText = "AccountOwnerID";
            this.accountOwnerIDDataGridViewTextBoxColumn.Name = "accountOwnerIDDataGridViewTextBoxColumn";
            this.accountOwnerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            this.accountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billNumberDataGridViewTextBoxColumn
            // 
            this.billNumberDataGridViewTextBoxColumn.DataPropertyName = "BillNumber";
            this.billNumberDataGridViewTextBoxColumn.HeaderText = "BillNumber";
            this.billNumberDataGridViewTextBoxColumn.Name = "billNumberDataGridViewTextBoxColumn";
            this.billNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryCodeDataGridViewTextBoxColumn
            // 
            this.categoryCodeDataGridViewTextBoxColumn.DataPropertyName = "CategoryCode";
            this.categoryCodeDataGridViewTextBoxColumn.HeaderText = "CategoryCode";
            this.categoryCodeDataGridViewTextBoxColumn.Name = "categoryCodeDataGridViewTextBoxColumn";
            this.categoryCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referenceDataGridViewTextBoxColumn
            // 
            this.referenceDataGridViewTextBoxColumn.DataPropertyName = "Reference";
            this.referenceDataGridViewTextBoxColumn.HeaderText = "Reference";
            this.referenceDataGridViewTextBoxColumn.Name = "referenceDataGridViewTextBoxColumn";
            this.referenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Errors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Success";
            // 
            // _cmbDataStatus
            // 
            this._cmbDataStatus.AllowUserToAddRows = false;
            this._cmbDataStatus.AllowUserToDeleteRows = false;
            this._cmbDataStatus.AllowUserToResizeRows = false;
            this._cmbDataStatus.AutoGenerateColumns = false;
            this._cmbDataStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._cmbDataStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dateOfPaymentDataGridViewTextBoxColumn,
            this.dateOfPaymentSpecifiedDataGridViewCheckBoxColumn});
            this._cmbDataStatus.DataSource = this.paymentsResultBindingSource;
            this._cmbDataStatus.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._cmbDataStatus.Location = new System.Drawing.Point(12, 12);
            this._cmbDataStatus.Name = "_cmbDataStatus";
            this._cmbDataStatus.ReadOnly = true;
            this._cmbDataStatus.RowHeadersVisible = false;
            this._cmbDataStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._cmbDataStatus.ShowEditingIcon = false;
            this._cmbDataStatus.Size = new System.Drawing.Size(504, 78);
            this._cmbDataStatus.TabIndex = 11;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfPaymentDataGridViewTextBoxColumn
            // 
            this.dateOfPaymentDataGridViewTextBoxColumn.DataPropertyName = "DateOfPayment";
            this.dateOfPaymentDataGridViewTextBoxColumn.HeaderText = "DateOfPayment";
            this.dateOfPaymentDataGridViewTextBoxColumn.Name = "dateOfPaymentDataGridViewTextBoxColumn";
            this.dateOfPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfPaymentDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateOfPaymentSpecifiedDataGridViewCheckBoxColumn
            // 
            this.dateOfPaymentSpecifiedDataGridViewCheckBoxColumn.DataPropertyName = "DateOfPaymentSpecified";
            this.dateOfPaymentSpecifiedDataGridViewCheckBoxColumn.HeaderText = "DateOfPaymentSpecified";
            this.dateOfPaymentSpecifiedDataGridViewCheckBoxColumn.Name = "dateOfPaymentSpecifiedDataGridViewCheckBoxColumn";
            this.dateOfPaymentSpecifiedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.dateOfPaymentSpecifiedDataGridViewCheckBoxColumn.Width = 150;
            // 
            // _cmbDataErrors
            // 
            this._cmbDataErrors.AllowUserToAddRows = false;
            this._cmbDataErrors.AllowUserToDeleteRows = false;
            this._cmbDataErrors.AllowUserToResizeRows = false;
            this._cmbDataErrors.AutoGenerateColumns = false;
            this._cmbDataErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._cmbDataErrors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn,
            this.PaymentIn});
            this._cmbDataErrors.DataSource = this.errorBindingSource;
            this._cmbDataErrors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._cmbDataErrors.Location = new System.Drawing.Point(12, 258);
            this._cmbDataErrors.MultiSelect = false;
            this._cmbDataErrors.Name = "_cmbDataErrors";
            this._cmbDataErrors.ReadOnly = true;
            this._cmbDataErrors.RowHeadersVisible = false;
            this._cmbDataErrors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._cmbDataErrors.ShowEditingIcon = false;
            this._cmbDataErrors.Size = new System.Drawing.Size(504, 106);
            this._cmbDataErrors.TabIndex = 10;
            this._cmbDataErrors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataErrors_CellContentClick);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.ReadOnly = true;
            this.messageDataGridViewTextBoxColumn.Width = 300;
            // 
            // PaymentIn
            // 
            this.PaymentIn.DataPropertyName = "Code";
            this.PaymentIn.HeaderText = "PaymentIn";
            this.PaymentIn.Name = "PaymentIn";
            this.PaymentIn.ReadOnly = true;
            // 
            // _cmbDataSuccess
            // 
            this._cmbDataSuccess.AllowUserToAddRows = false;
            this._cmbDataSuccess.AllowUserToDeleteRows = false;
            this._cmbDataSuccess.AllowUserToResizeRows = false;
            this._cmbDataSuccess.AutoGenerateColumns = false;
            this._cmbDataSuccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._cmbDataSuccess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.SuccessfulTransfer});
            this._cmbDataSuccess.DataSource = this.paymentResultDetailsBindingSource;
            this._cmbDataSuccess.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._cmbDataSuccess.Location = new System.Drawing.Point(12, 122);
            this._cmbDataSuccess.MultiSelect = false;
            this._cmbDataSuccess.Name = "_cmbDataSuccess";
            this._cmbDataSuccess.ReadOnly = true;
            this._cmbDataSuccess.RowHeadersVisible = false;
            this._cmbDataSuccess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._cmbDataSuccess.ShowEditingIcon = false;
            this._cmbDataSuccess.Size = new System.Drawing.Size(504, 110);
            this._cmbDataSuccess.TabIndex = 9;
            this._cmbDataSuccess.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataSuccess_CellContentClick);
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.DataPropertyName = "Item";
            this.dataGridViewLinkColumn1.HeaderText = "Transfer";
            this.dataGridViewLinkColumn1.LinkColor = System.Drawing.Color.Teal;
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.ReadOnly = true;
            // 
            // dataGridViewLinkColumn2
            // 
            this.dataGridViewLinkColumn2.DataPropertyName = "Item";
            this.dataGridViewLinkColumn2.HeaderText = "Transfer";
            this.dataGridViewLinkColumn2.LinkColor = System.Drawing.Color.Red;
            this.dataGridViewLinkColumn2.Name = "dataGridViewLinkColumn2";
            this.dataGridViewLinkColumn2.ReadOnly = true;
            this.dataGridViewLinkColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ErroredTransfer
            // 
            this.ErroredTransfer.DataPropertyName = "Item";
            this.ErroredTransfer.HeaderText = "Transfer";
            this.ErroredTransfer.LinkColor = System.Drawing.Color.Red;
            this.ErroredTransfer.Name = "ErroredTransfer";
            this.ErroredTransfer.ReadOnly = true;
            this.ErroredTransfer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SuccessfulTransfer
            // 
            this.SuccessfulTransfer.DataPropertyName = "Item";
            this.SuccessfulTransfer.HeaderText = "Transfer";
            this.SuccessfulTransfer.LinkColor = System.Drawing.Color.Teal;
            this.SuccessfulTransfer.Name = "SuccessfulTransfer";
            this.SuccessfulTransfer.ReadOnly = true;
            // 
            // PaymentResponseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 729);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._cmbDataErroredPaymentIn);
            this.Controls.Add(this._cmbDataTransfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cmbDataStatus);
            this.Controls.Add(this._cmbDataErrors);
            this.Controls.Add(this._cmbDataSuccess);
            this.Name = "PaymentResponseForm";
            this.Text = "Payment result";
            ((System.ComponentModel.ISupportInitialize)(this.paymentsResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentResultDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmbDataErroredPaymentIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmbDataTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmbDataStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmbDataErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmbDataSuccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource paymentsResultBindingSource;
        private System.Windows.Forms.BindingSource paymentResultDetailsBindingSource;
        private System.Windows.Forms.BindingSource paymentInBindingSource;
        private System.Windows.Forms.BindingSource errorBindingSource;
        private System.Windows.Forms.BindingSource errorsBindingSource;
        private System.Windows.Forms.BindingSource transferBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView _cmbDataErroredPaymentIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn ErroredTransfer;
        private System.Windows.Forms.DataGridView _cmbDataTransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountOwnerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView _cmbDataStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dateOfPaymentSpecifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView _cmbDataErrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn PaymentIn;
        private System.Windows.Forms.DataGridView _cmbDataSuccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn SuccessfulTransfer;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn2;

    }
}