using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Web.Services3.Security.Tokens;
using Microsoft.Web.Services3;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Web.Services3.Security;
using System.IO;
using System.Web.Services.Protocols;
using System.Reflection;
using IsIT.B2B.Common.Security;
using IsIT.B2B.DoPaymentTest.Properties;
using IsIT.B2B.DoPaymentTest.UIData;
using IsIT.B2B.DoPaymentTest.PaymentsService;
using System.Net;

namespace IsIT.B2B.DoPaymentTest
{
    public partial class Paymentform : Form
    {
        #region UI Logic

        private Payments payments = new IsIT.B2B.DoPaymentTest.PaymentsService.Payments();
        private BindingList<PaymentIn> paymentIns = new BindingList<PaymentIn>();
        private BindingList<CommunicationEMail> outEmails = new BindingList<CommunicationEMail>();

        public Paymentform()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _cmbFilter.DataSource = Enum.GetNames(typeof(PaymentsStatus));

            onlineBankingCertificateBindingSource.DataSource = OnlineBankingCertificate.GetCertificates();

            languageBindingSource.DataSource = Language.GetLanguages();
            categoryCodeBindingSource.DataSource = CategoryCode.GetCategoryCodes();
            categoryCodeBindingSource1.DataSource = CategoryCode.GetCategoryCodes();

            payments.Out = new PaymentOut();
            payments.Out.Receipt = new Communication();
            paymentIns.AddNew();

            paymentsBindingSource.DataSource = payments;
            communicationEMailBindingSource.DataSource = outEmails;
            inBindingSource.DataSource = paymentIns;
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
            if (inBindingSource.Current == null)
            {
                return;
            }
            PaymentIn currentPaymentIn = (PaymentIn)inBindingSource.Current;
            if (currentPaymentIn.Item == null)
            {
                currentPaymentIn.Item = new Transfer();
            }
            transferBindingSource.DataSource = currentPaymentIn.Item;
        }

        #endregion

        #region Business Logic

        private void doPaymentsButton_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            try
            {
                Settings.Default.Save();

                if (outEmails.Count != 0)
                {
                    payments.Out.Receipt.EMail = new List<CommunicationEMail>(outEmails).ToArray();
                }
                payments.In = new List<PaymentIn>(paymentIns).ToArray();

                IcelandicOnlineBankingPaymentsService service = new IcelandicOnlineBankingPaymentsService();
                service.Credentials = CredentialCache.DefaultNetworkCredentials;
                service.Proxy = WebRequest.GetSystemWebProxy();
                service.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials;
                service.Url = IOBUrlTextBox.Text;

                OnlineBankingCertificate certificate = (OnlineBankingCertificate)onlineBankingCertificateBindingSource.Current;
                WseSecurityHelper.SetSecurity(service, certificate, UserNameTextBox.Text, PasswordTextBox.Text);

                doPaymentResultsTextBox.Text = service.DoPayments(payments);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHandler.GetMessage(ex), ex.GetType().Name);
            }
            finally
            {
                this.UseWaitCursor = false;
            }
        }

        private void getResultsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Save();

                if (string.IsNullOrEmpty(doPaymentResultsTextBox.Text))
                {
                    doPaymentResultsTextBox.Focus();
                    throw new ArgumentException("Please enter a valid Payments ID");
                }

                IcelandicOnlineBankingPaymentsService service = new IcelandicOnlineBankingPaymentsService();
                service.Credentials = CredentialCache.DefaultNetworkCredentials;
                service.Proxy = WebRequest.GetSystemWebProxy();
                service.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials;

                OnlineBankingCertificate certificate = (OnlineBankingCertificate)onlineBankingCertificateBindingSource.Current;
                WseSecurityHelper.SetSecurity(service, certificate, UserNameTextBox.Text, PasswordTextBox.Text);

                PaymentsResult result = service.GetPaymentsResult(doPaymentResultsTextBox.Text, (PaymentsStatus)Enum.Parse(typeof(PaymentsStatus), _cmbFilter.SelectedValue.ToString()));
                PaymentResponseForm paymentResponseForm = new PaymentResponseForm();
                paymentResponseForm.Initialize(result);
                paymentResponseForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHandler.GetMessage(ex), ex.GetType().Name);
            }
        }

        #endregion


    }
}
