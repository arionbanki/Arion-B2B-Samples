using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IsIT.B2B.DoPaymentTest.PaymentsService;

namespace IsIT.B2B.DoPaymentTest
{
    public partial class PaymentResponseForm : Form
    {
        public PaymentResponseForm()
        {
            InitializeComponent();
        }

        public void Initialize(PaymentsResult result)
        {
            paymentsResultBindingSource.DataSource = result;
            if (result.Success != null)
            {
                paymentResultDetailsBindingSource.DataSource = result.Success;
            }
            if (result.Errors != null)
            {
                errorBindingSource.DataSource = result.Errors;
            }
        }

        private void _dataSuccess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            transferBindingSource.DataSource = ((PaymentResultDetails)paymentResultDetailsBindingSource.Current).Item;
        }

        private void _dataErrors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            paymentInBindingSource.DataSource = ((PaymentError)errorBindingSource.Current).Payment;
        }

        private void _dataErroredPaymentIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            transferBindingSource.DataSource = ((PaymentIn)paymentInBindingSource.Current).Item;
        }

    }
}
