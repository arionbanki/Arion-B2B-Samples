using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IsIT.B2B.Common.Security;
using IsIT.B2B.AccountServiceTest.Account20130101Proxy;
using System.ServiceModel;
using IsIT.B2B.Common;
using System.Collections.ObjectModel;
using System.ServiceModel.Channels;

namespace IsIT.B2B.AccountServiceTest
{
    public partial class Form1 : Form
    {
        public const string Security_Namespace = "http://IcelandicOnlineBanking/Security/";

        public Form1()
        {
            InitializeComponent();
        }

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup Controls
            this.onlineBankingCertificateBindingSource.DataSource = OnlineBankingCertificate.GetCertificates();
        }

        private void _btnGetAccounts_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            btnGetAccounts.Enabled = false;
            ClearAccountsResult();
            try
            {
                var accounts = this.GetAccounts();
                this.AddAccountsResult(accounts);
            }
            catch (Exception x)
            {
                MessageBox.Show("Unable to GetAccounts due to: " + x.Message);
            }
            finally
            {
                btnGetAccounts.Enabled = true;
                Application.UseWaitCursor = false;
            }
        }

        #endregion
        
        #region UI

        private void AddAccountsResult(Collection<Account> accounts)
        {
            var treeNodes = this.TranslateAccountListToTreeNode(accounts);
            treeViewAccountsResult.Nodes.Add(treeNodes);
            treeViewAccountsResult.ExpandAll();
            string message = (accounts.Count > 0) ? "Aðgerð tókst, Fjöldi er " + accounts.Count : "Aðgerð tókst ekki";
            MessageBox.Show(message);
        }

        private void ClearAccountsResult()
        {
            treeViewAccountsResult.Nodes.Clear();
        }

        #endregion

        #region Service Logic

        private Collection<Account> GetAccounts()
        {
            var accounts = new Collection<Account>();
            try
            {
                // Create Service Factory
                using (var client = new ServiceProxy<IAccountServiceChannel>())
                {
                    try
                    {
                        OnlineBankingCertificate certificate = (OnlineBankingCertificate)onlineBankingCertificateBindingSource.Current;

                        // Add X509 Security token
                        WcfSecurityHelper<IAccountServiceChannel>.SetWcfCertificateCredentials(client, IOBUrlTextBox.Text, certificate);

                        // Configure Endpoint Identity
                        WcfSecurityHelper<IAccountServiceChannel>.SetEndpointIdentity(client, IOBUrlTextBox.Text);

                        // Server certificate, get from certificate store or config
                        //var serverCertificate = ((System.ServiceModel.X509CertificateEndpointIdentity)client.Endpoint.Address.Identity).Certificates.[0];
                        //WcfSecurityHelper<IAccountServiceChannel>.SetWcfCertificateCredentials(client, IOBUrlTextBox.Text, certificate, serverCertificate);

                        // Add Username Soap header
                        using (OperationContextScope scope = new OperationContextScope(client.Proxy))
                        {
                            MessageHeader<string> userHeader = new MessageHeader<string>(UserNameTextBox.Text);
                            var userUntyped = userHeader.GetUntypedHeader("UserName", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(userUntyped);

                            MessageHeader<string> pwdHeader = new MessageHeader<string>(PasswordTextBox.Text);
                            var pwdUntyped = pwdHeader.GetUntypedHeader("Password", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(pwdUntyped);

                            // Call GetAccounts
                            accounts = client.Proxy.GetAccounts();                            
                        }
                    }
                    catch (FaultException<BankErrorFault> ex)
                    {
                        throw new Exception(this.GetDetailMessage(ex), ex);
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
                return accounts;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region Helpers

        internal string GetDetailMessage(FaultException<BankErrorFault> ex)
        {
            var message = string.Empty;
            message += "Exception:  " + ex.Message;
            if (ex.InnerException != null)
            {
                message += "\n";
                message += "Inner Exception:  " + ex.Message;
            }

            if (ex.Detail != null)
            {
                message += "\n";
                message += "General error text:  " + ex.Detail.GeneralErrorText + "\n";
                message += "General error code:  " + ex.Detail.GeneralErrorCode + "\n";
                message += "Bank error code:  " + ex.Detail.BanksErrorCode + "\n";
                message += "Bank error text:  " + ex.Detail.BanksErrorText + "\n";
            }
            return message;
        }

        internal TreeNode TranslateAccountListToTreeNode(Collection<Account> accounts)
        {
            var nodes = new List<TreeNode>();            
            foreach (var account in accounts)
	        {
                var text = string.Concat(account.AccountName, " ", account.AccountType);
                var node = new TreeNode(text);
                nodes.Add(node);
	        }

            var returnValue = new TreeNode("Accounts", nodes.ToArray());
            return returnValue;
        }

        #endregion
    }
}
