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
using IsIT.B2B.StatementsTest.Properties;
using IsIT.B2B.Common.Security;
using IsIT.B2B.StatementsTest.StatementsService;
using System.Net;

namespace IsIT.B2B.StatementsTest
{
    public partial class StatementsForm : Form
    {
        #region UI Logic
        public StatementsForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            onlineBankingCertificateBindingSource.DataSource = OnlineBankingCertificate.GetCertificates();
        }
        #endregion

        #region Business Logic
        private void ExchangeRateButton_Click(object sender, EventArgs e)
        {            
            this.UseWaitCursor = true;
            try
            {
                Settings.Default.Save();

                IcelandicOnlineBankingStatementsService service = new IcelandicOnlineBankingStatementsService();
                service.Credentials = CredentialCache.DefaultNetworkCredentials;
                service.Proxy = WebRequest.GetSystemWebProxy();
                service.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials;
                service.Url = IOBUrlTextBox.Text;

                OnlineBankingCertificate certificate = (OnlineBankingCertificate)onlineBankingCertificateBindingSource.Current;

                WseSecurityHelper.SetSecurity(service, certificate, UserNameTextBox.Text, PasswordTextBox.Text);

                //currencyRateBindingSource.DataSource = service.GetCurrencyRates(CurrencyType.ExchangeRate, DateTime.Now);

                service.GetCurrencyRatesCompleted += new GetCurrencyRatesCompletedEventHandler(service_GetCurrencyRatesCompleted);
                service.GetCurrencyRatesAsync(CurrencyType.ExchangeRate, DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHandler.GetMessage(ex), ex.GetType().Name);
            }
            finally
            {
                exchangeRateButton.Enabled = false;
                this.UseWaitCursor = false;
            }                       
        }

        void service_GetCurrencyRatesCompleted(object sender, GetCurrencyRatesCompletedEventArgs e)
        {
            exchangeRateButton.Enabled = true;

            try
            {
                currencyRateBindingSource.DataSource = e.Result;
            }
            catch (Exception ex)
            {
                exchangeRateButton.Enabled = true;
                MessageBox.Show(ExceptionHandler.GetMessage(ex), ex.GetType().Name);
            }
        }
        #endregion
    }
}
