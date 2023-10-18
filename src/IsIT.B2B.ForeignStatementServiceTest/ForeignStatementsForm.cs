using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.ServiceModel;
using IsIT.B2B.Common;
using IsIT.B2B.Common.Security;
using IsIT.B2B.ForeignStatementServiceTest.ForeignStatementServiceProxy;

namespace IsIT.B2B.ForeignStatementServiceTest
{
    using System.Diagnostics;
    using System.Drawing;

    public partial class ForeignStatementsForm : Form
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
        /// Einkvæmt númer reiknings sem er valið í lista
        /// </summary>
        private string currentCardId = "";

        public ForeignStatementsForm()
        {
            InitializeComponent();
        }

        #region UI

        private void AddForeignAccountsResult(ForeignAccountsResult accountsResult)
        {
            var treeNodes = this.TranslateListToTreeNode(accountsResult.Accounts);
            treeViewResult.Nodes.Add(treeNodes);
            treeViewResult.ExpandAll();
            string message = (accountsResult.Accounts.Count > 0) ? "Aðgerð tókst, Fjöldi er " + accountsResult.Accounts.Count : "Aðgerð tókst ekki";
            MessageBox.Show(message);
        }

        private void ClearForeignAccountsResult()
        {
            treeViewResult.Nodes.Clear();
            groupBoxDetails.Visible = false;
            pictureBoxLoading.Enabled = false;
        }

        private void GetStatements(string accountNumber, int pageNumber)
        {
            dataGridViewStatements.Visible = false;
            ShowLoading();

            var result = this.GetForeignAccountStatementResult(accountNumber, pageNumber);

            // DataBind Statements
            if (result.Statements != null)
            {
                dataGridViewStatements.DataSource = result.Statements;
            }

            // Update Total Pages
            this.totalPages = 0;
            if (this.pageSize > 0)
            {
                this.totalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(result.TotalCount) / Convert.ToDecimal(pageSize)));
            }
                        
            lblPageInfo.Text = "Page " + this.currentPageIndex + " of " + this.totalPages;
            dataGridViewStatements.Visible = true;
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

        private ForeignAccountsResult GetForeignAccounts()
        {
            var result = default(ForeignAccountsResult);
            try
            {
                // Create Service Factory
                using (var client = new ServiceProxy<IForeignStatementServiceChannel>())
                {
                    try
                    {
                        OnlineBankingCertificate certificate = (OnlineBankingCertificate)onlineBankingCertificateBindingSource.Current;

                        // Add X509 Security token
                        WcfSecurityHelper<IForeignStatementServiceChannel>.SetWcfCertificateCredentials(client, IOBUrlTextBox.Text, certificate);

                        // Configure Endpoint Identity
                        WcfSecurityHelper<IForeignStatementServiceChannel>.SetEndpointIdentity(client, IOBUrlTextBox.Text);

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
                            var request = new ForeignAccountsQuery { PageNumber = 1, PageSize = int.MaxValue };
                            result = client.Proxy.GetForeignAccounts(request);
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
        
        private ForeignAccountStatementResult GetForeignAccountStatementResult(string accountNumber, int pageNumber)
        {
            var result = default(ForeignAccountStatementResult);
            try
            {
                // Create Service Factory
                using (var client = new ServiceProxy<IForeignStatementServiceChannel>())
                {
                    try
                    {
                        OnlineBankingCertificate certificate = (OnlineBankingCertificate)onlineBankingCertificateBindingSource.Current;

                        // Add X509 Security token
                        WcfSecurityHelper<IForeignStatementServiceChannel>.SetWcfCertificateCredentials(client, IOBUrlTextBox.Text, certificate);

                        // Configure Endpoint Identity
                        WcfSecurityHelper<IForeignStatementServiceChannel>.SetEndpointIdentity(client, IOBUrlTextBox.Text);

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
                            var request = new ForeignAccountStatementQuery
                                              {
                                                  Account = accountNumber,
                                                  DateFrom = this.dateTimePickerFrom.Value,
                                                  DateTo = this.dateTimePickerTo.Value,
                                                  PageNumber = pageNumber,
                                                  PageSize = this.pageSize
                                              };                                              
                                                        
                            result = client.Proxy.GetForeignAccountStatements(request);                            
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

        internal TreeNode TranslateListToTreeNode(Collection<ForeignAccount> list)
        {
            var nodes = new List<TreeNode>();
            foreach (var entry in list)
            {
                var text = string.Concat(entry.AccountNumber, " ", "Owner: " + entry.OwnerPersonId + " OwnerName: " + entry.OwnerName + " Balance: " + entry.Balance.ToString() + " ISK");
                var node = new TreeNode(text);
                node.Tag = entry.AccountNumber;
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
            ClearForeignAccountsResult();
            try
            {
                var result = this.GetForeignAccounts();
                this.AddForeignAccountsResult(result);
            }
            catch (Exception x)
            {
                MessageBox.Show("Unable to ForeignAccounts due to: " + x.Message);
            }
            finally
            {
                btnGet.Enabled = true;
                Application.UseWaitCursor = false;
            }
        }

        private void treeViewResult_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.currentCardId = string.Empty;
            lblAccountNumber.Text = string.Empty;
            if (treeViewResult.SelectedNode != null)
            {
                panelNavigation.Visible = false;
                groupBoxDetails.Visible = true;
                ShowLoading();
                this.currentCardId = treeViewResult.SelectedNode.Tag.ToString();
                                
                lblAccountNumber.Text = "AccoutNumber : " + this.currentCardId;                

                this.GetStatements(this.currentCardId, this.currentPageIndex);
                panelNavigation.Visible = true;
                
                HideLoading();
            }
        }

        private void ForeignStatementsForm_Shown(object sender, EventArgs e)
        {
            // Setup Controls
            this.onlineBankingCertificateBindingSource.DataSource = OnlineBankingCertificate.GetCertificates();

            dateTimePickerFrom.Value = DateTime.Today.AddMonths(-1);

            dateTimePickerTo.Value = DateTime.Now;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFirstPAge_Click(object sender, EventArgs e)
        {
            this.currentPageIndex = 1;

            // Get Page
            this.GetStatements(this.currentCardId, this.currentPageIndex);
        }

        private void btnNxtPage_Click(object sender, EventArgs e)
        {
            if (this.currentPageIndex < this.totalPages)
            {
                this.currentPageIndex++;

                // Get Page
                this.GetStatements(this.currentCardId, this.currentPageIndex);
            }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (this.currentPageIndex > 1)
            {
                this.currentPageIndex--;
                this.GetStatements(this.currentCardId, this.currentPageIndex);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            this.currentPageIndex = totalPages;
            this.GetStatements(this.currentCardId, this.currentPageIndex);
        }

        #endregion

        private void ForeignStatementsForm_Load(object sender, EventArgs e)
        {
            pictureBoxLoading.Image = Image.FromFile("Img\\pictureBoxLoading.gif");
        }

        private void dataGridViewTransactions_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            var rowSelected = e.RowIndex;
            if (e.RowIndex == -1)
            {
                return;
            }

            this.dataGridViewStatements.ClearSelection();
            this.dataGridViewStatements.Rows[rowSelected].Selected = true;
            this.dataGridViewStatements.ContextMenuStrip.Items[0].Enabled = (this.dataGridViewStatements.Rows[rowSelected].Cells["StatementData"].Value != null);
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            var menuStrip = (sender as ContextMenuStrip);
            if (menuStrip != null)
            {
                if (this.dataGridViewStatements.SelectedRows.Count > 0 && this.dataGridViewStatements.SelectedRows[0].Cells["StatementData"].Value != null)
                {                    
                    WriteAndOpenFile(this.dataGridViewStatements.SelectedRows[0].Cells["StatementData"].Value.ToString());
                }
                
            }            
        }

        /// <summary>
        /// Skrifar út skrá og opnar í notepad
        /// </summary>
        /// <param name="value">The value.</param>
        private static void WriteAndOpenFile(string value)
        {
            // Get temp file
            var outputFile = Path.GetTempFileName();

            // Write file
            File.WriteAllText(outputFile, value);

            // Start Notepad
            var process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                UseShellExecute = false,
                FileName = @"notepad.exe",
                Arguments = outputFile
            };
            process.Start();
        }
    }
}
