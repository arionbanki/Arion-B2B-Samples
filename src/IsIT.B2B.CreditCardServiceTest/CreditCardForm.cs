using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
using IsIT.B2B.Common;
using IsIT.B2B.Common.Security;
using IsIT.B2B.CreditCardServiceTest.CreditCard20130901Proxy;

namespace IsIT.B2B.CreditCardServiceTest
{
    public partial class CreditCardForm : Form
    {
        public const string Security_Namespace = "http://IcelandicOnlineBanking/Security/";

        /// <summary>
        /// Fjöldi færsla sem birtist per blaðsíðu
        /// </summary>
        private int pageSize = 8;

        /// <summary>
        /// Núverandi blaðsíðunúmer
        /// </summary>
        private int currentPageIndex = 1;

        /// <summary>
        /// Fjöldi blaðsíða af færslum (Fer eftir fjölda á blaðsíðu og fjölda færsla)
        /// </summary>
        private int totalPages = 0;

        /// <summary>
        /// Einkvæmt númer korts sem er valið í lista
        /// </summary>
        private long currentCardId = 0;

        public CreditCardForm()
        {
            InitializeComponent();
        }

        #region UI

        private void AddCreditCardsResult(Collection<CreditCard> cards)
        {
            var treeNodes = this.TranslateListToTreeNode(cards);
            treeViewResult.Nodes.Add(treeNodes);
            treeViewResult.ExpandAll();
            string message = (cards.Count > 0) ? "Aðgerð tókst, Fjöldi er " + cards.Count : "Aðgerð tókst ekki";
            MessageBox.Show(message);
        }

        private void ClearCreditCardsResult()
        {
            treeViewResult.Nodes.Clear();
            groupBoxDetails.Visible = false;
            pictureBoxLoading.Enabled = false;
        }

        private void GetTransactions(long cardId, int pageNumber)
        {
            dataGridViewTransactions.Visible = false;
            ShowLoading();

            var result = GetCreditCardTransactionResult(cardId, pageNumber, pageSize);

            // DataBind Transaction
            if (result.Transactions != null)
            {
                dataGridViewTransactions.DataSource = result.Transactions;
            }

            // Update Total Pages
            if (result.Paging != null)
            {
                this.totalPages = result.Paging.TotalPages;
            }

            lblPageInfo.Text = "Page " + this.currentPageIndex + " of " + this.totalPages;
            dataGridViewTransactions.Visible = true;
            HideLoading();
        }

        private void HideLoading()
        {
            pictureBoxLoading.Enabled = false;
            pictureBoxLoading.Visible = false;
        }

        private void ShowLoading()
        {
            pictureBoxLoading.Visible = true;
            pictureBoxLoading.Enabled = true;
        }

        #endregion

        #region Service Logic

        private Collection<CreditCard> GetCreditCards()
        {
            var result = new Collection<CreditCard>();
            try
            {
                // Create Service Factory
                using (var client = new ServiceProxy<ICreditCardServiceChannel>())
                {
                    try
                    {
                        OnlineBankingCertificate certificate = (OnlineBankingCertificate)onlineBankingCertificateBindingSource.Current;

                        // Add X509 Security token
                        WcfSecurityHelper<ICreditCardServiceChannel>.SetWcfCertificateCredentials(client, IOBUrlTextBox.Text, certificate);

                        // Configure Endpoint Identity
                        WcfSecurityHelper<ICreditCardServiceChannel>.SetEndpointIdentity(client, IOBUrlTextBox.Text);

                        // Server certificate, get from certificate store or config
                        //var serverCertificate = ((System.ServiceModel.X509CertificateEndpointIdentity)client.Endpoint.Address.Identity).Certificates.[0];
                        //WcfSecurityHelper<IerviceChannel>.SetWcfCertificateCredentials(client, IOBUrlTextBox.Text, certificate, serverCertificate);

                        // Add Username Soap header
                        using (var scope = new OperationContextScope(client.Proxy))
                        {
                            var userHeader = new MessageHeader<string>(UserNameTextBox.Text);
                            var userUntyped = userHeader.GetUntypedHeader("UserName", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(userUntyped);

                            var pwdHeader = new MessageHeader<string>(PasswordTextBox.Text);
                            var pwdUntyped = pwdHeader.GetUntypedHeader("Password", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(pwdUntyped);

                            // Call Method                            
                            result = client.Proxy.GetCreditCards();
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
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private CreditCardDetails GetCreditCard(long cardId)
        {
            var result = default(CreditCardDetails);
            try
            {
                // Create Service Factory
                using (var client = new ServiceProxy<ICreditCardServiceChannel>())
                {
                    try
                    {
                        OnlineBankingCertificate certificate = (OnlineBankingCertificate)onlineBankingCertificateBindingSource.Current;

                        // Add X509 Security token
                        WcfSecurityHelper<ICreditCardServiceChannel>.SetWcfCertificateCredentials(client, IOBUrlTextBox.Text, certificate);

                        // Configure Endpoint Identity
                        WcfSecurityHelper<ICreditCardServiceChannel>.SetEndpointIdentity(client, IOBUrlTextBox.Text);

                        // Server certificate, get from certificate store or config
                        //var serverCertificate = ((System.ServiceModel.X509CertificateEndpointIdentity)client.Endpoint.Address.Identity).Certificates.[0];
                        //WcfSecurityHelper<IerviceChannel>.SetWcfCertificateCredentials(client, IOBUrlTextBox.Text, certificate, serverCertificate);

                        // Add Username Soap header
                        using (var scope = new OperationContextScope(client.Proxy))
                        {
                            var userHeader = new MessageHeader<string>(UserNameTextBox.Text);
                            var userUntyped = userHeader.GetUntypedHeader("UserName", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(userUntyped);

                            var pwdHeader = new MessageHeader<string>(PasswordTextBox.Text);
                            var pwdUntyped = pwdHeader.GetUntypedHeader("Password", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(pwdUntyped);

                            // Call Method
                            result = client.Proxy.GetCreditCard(cardId);
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
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private CreditCardTransactionResult GetCreditCardTransactionResult(long cardId, int pageNumber, int pageSize)
        {
            var result = default(CreditCardTransactionResult);
            try
            {
                // Create Service Factory
                using (var client = new ServiceProxy<ICreditCardServiceChannel>())
                {
                    try
                    {
                        OnlineBankingCertificate certificate = (OnlineBankingCertificate)onlineBankingCertificateBindingSource.Current;

                        // Add X509 Security token
                        WcfSecurityHelper<ICreditCardServiceChannel>.SetWcfCertificateCredentials(client, IOBUrlTextBox.Text, certificate);

                        // Configure Endpoint Identity
                        WcfSecurityHelper<ICreditCardServiceChannel>.SetEndpointIdentity(client, IOBUrlTextBox.Text);

                        // Server certificate, get from certificate store or config
                        //var serverCertificate = ((System.ServiceModel.X509CertificateEndpointIdentity)client.Endpoint.Address.Identity).Certificates.[0];
                        //WcfSecurityHelper<IerviceChannel>.SetWcfCertificateCredentials(client, IOBUrlTextBox.Text, certificate, serverCertificate);

                        // Add Username Soap header
                        using (var scope = new OperationContextScope(client.Proxy))
                        {
                            var userHeader = new MessageHeader<string>(UserNameTextBox.Text);
                            var userUntyped = userHeader.GetUntypedHeader("UserName", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(userUntyped);

                            var pwdHeader = new MessageHeader<string>(PasswordTextBox.Text);
                            var pwdUntyped = pwdHeader.GetUntypedHeader("Password", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(pwdUntyped);

                            // Call Method
                            result = client.Proxy.GetCreditCardTransactions(cardId, pageNumber, pageSize);
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
                return result;
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

        internal TreeNode TranslateListToTreeNode(Collection<CreditCard> list)
        {
            var nodes = new List<TreeNode>();
            foreach (var entry in list)
            {
                var text = string.Concat(entry.CardNumber, " ", "Owner: " + entry.CardOwnerId + " OwnerName: " + entry.CardOwnerName + " Balance: " + entry.Balance.ToString() + " ISK");
                var node = new TreeNode(text);
                node.Tag = entry.CardId;
                nodes.Add(node);
            }

            var returnValue = new TreeNode("Results", nodes.ToArray());
            return returnValue;
        }

        #endregion

        #region Events


        private void btnGet_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            btnGet.Enabled = false;
            ClearCreditCardsResult();
            try
            {
                var result = this.GetCreditCards();
                this.AddCreditCardsResult(result);
            }
            catch (Exception x)
            {
                MessageBox.Show("Unable to GetCreditCards due to: " + x.Message);
            }
            finally
            {
                btnGet.Enabled = true;
                Application.UseWaitCursor = false;
            }
        }

        private void treeViewResult_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.currentCardId = 0;
            lblCardHolderId.Text = string.Empty;
            lblCardHolderName.Text = string.Empty;
            if (treeViewResult.SelectedNode != null)
            {
                panelNavigation.Visible = false;
                groupBoxDetails.Visible = true;
                ShowLoading();
                this.currentCardId = Int64.Parse(treeViewResult.SelectedNode.Tag.ToString(), NumberStyles.None, CultureInfo.InvariantCulture);
                var details = GetCreditCard(this.currentCardId);

                if (details != null)
                {

                    lblCardHolderId.Text = "CardHolderId : " + details.CardHolderId;
                    lblCardHolderName.Text = "CardHolderName : " + details.CardHolderName;

                    this.GetTransactions(this.currentCardId, this.currentPageIndex);

                    panelNavigation.Visible = true;
                }
                HideLoading();
            }

        }

        private void CreditCardForm_Shown(object sender, EventArgs e)
        {
            // Setup Controls
            this.onlineBankingCertificateBindingSource.DataSource = OnlineBankingCertificate.GetCertificates();
        }



        private void groupBoxDetails_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFirstPAge_Click(object sender, EventArgs e)
        {
            this.currentPageIndex = 1;

            // Get Page
            this.GetTransactions(this.currentCardId, this.currentPageIndex);
        }

        private void btnNxtPage_Click(object sender, EventArgs e)
        {
            if (this.currentPageIndex < this.totalPages)
            {
                this.currentPageIndex++;

                // Get Page
                this.GetTransactions(this.currentCardId, this.currentPageIndex);
            }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (this.currentPageIndex > 1)
            {
                this.currentPageIndex--;
                this.GetTransactions(this.currentCardId, this.currentPageIndex);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            this.currentPageIndex = totalPages;
            this.GetTransactions(this.currentCardId, this.currentPageIndex);
        }

        #endregion

        private void dataGridViewTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreditCardForm_Load(object sender, EventArgs e)
        {
            pictureBoxLoading.Image = Image.FromFile("Img\\pictureBoxLoading.gif");
        }

    }
}
