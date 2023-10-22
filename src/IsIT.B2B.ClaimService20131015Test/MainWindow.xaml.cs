using IsIT.B2B.ClaimService20131015Test.ClaimServiceProxy;
using IsIT.B2B.Common;
using IsIT.B2B.Common.Security;
using IsIT.B2B.Common.Trace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using System.Xml;
using System.Xml.Xsl;

namespace IsIT.B2B.ClaimService20131015Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const string Security_Namespace = "http://IcelandicOnlineBanking/Security/";

        private static MessageViewerInspector inspector = new MessageViewerInspector();

        private BindingList<object> _certs;
        public BindingList<object> Certs
        {
            get { return _certs; }
            set { _certs = value; }
        }


        public MainWindow()
        {
            InitializeComponent();
        }


        #region Events

        private void btnQueryClaims_Click(object sender, RoutedEventArgs e)
        {
            queryClaimsDataGrid1.DataContext = null;
            Mouse.OverrideCursor = Cursors.Wait;
            btnQueryClaims.IsEnabled = false;
            try
            {
                Dispatcher.Invoke(
                    DispatcherPriority.Background,
                    (Action)delegate ()
                    {
                        queryClaimsDataGrid1.DataContext = this.QueryClaims();
                    }
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to search for claims due to: " + ex.Message);
            }
            finally
            {
                btnQueryClaims.IsEnabled = true;
                Mouse.OverrideCursor = null;
            }
        }

        #endregion

        #region Business Methods

        private ClaimsQuery SetupMultiQuery()
        {
            var query = new ClaimsQuery();
            query.Claimant = "6606129980";
            query.Identifier = "100";
            query.RecordFrom = UInt32.Parse(txtRecordFrom.Text);
            query.RecordTo = UInt32.Parse(txtRecordTo.Text);
            query.Claimant = txtQueryClaimClaimant.Text;
            query.Payor = string.IsNullOrEmpty(txtQueryClaimPayor.Text) ? null : txtQueryClaimPayor.Text;
            query.Identifier = string.IsNullOrEmpty(txtQueryClaimIdentifier.Text) ? null : txtQueryClaimIdentifier.Text;
            return query;
        }

        private ClaimInfo[] QueryClaims()
        {

            this.ClearTrace();
            Mouse.OverrideCursor = Cursors.Wait;
            var result = default(ClaimInfo[]);
            try
            {
                // Call QueryClaims for Multiple Claims

                using (var client = new ServiceProxy<IIcelandicOnlineBankingClaimServiceChannel>())
                {
                    try
                    {
                        var certificate = (OnlineBankingCertificate)ComboBoxCertificate.SelectedItem;

                        // Add X509 Security token
                        WcfSecurityHelper<IIcelandicOnlineBankingClaimServiceChannel>.SetWcfCertificateCredentials(client, comboBoxUrl.Text, certificate);

                        // Configure Endpoint Identity
                        WcfSecurityHelper<IIcelandicOnlineBankingClaimServiceChannel>.SetEndpointIdentity(client, comboBoxUrl.Text);

                        // Add Message Trace
                        this.AddMessageInspector(client);

                        // Add Username Soap header
                        using (var scope = new OperationContextScope(client.Proxy))
                        {
                            var userHeader = new MessageHeader<string>(UserNameTextBox.Text);
                            var userUntyped = userHeader.GetUntypedHeader("UserName", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(userUntyped);

                            var pwdHeader = new MessageHeader<string>(PasswordTextBox.Password);
                            var pwdUntyped = pwdHeader.GetUntypedHeader("Password", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(pwdUntyped);

                            //Setup Multi Query
                            var query = SetupMultiQuery();

                            // Query Multiple Claims                                
                            QueryClaimsResult results = client.Proxy.QueryClaims(query);

                            result = results.Claims;
                        }
                    }
                    catch (FaultException<IOBSFault> ex)
                    {
                        throw new Exception(this.GetDetailMessage(ex), ex);
                    }
                }
                return result;
            }
            finally
            {
                this.UpdateTrace();
            }
        }

        private ClaimOperationResult GetClaimOperationResult(string id)
        {

            this.ClearTrace();
            Mouse.OverrideCursor = Cursors.Wait;
            var result = default(ClaimOperationResult);
            try
            {
                // Call GetClaimOperationResult
                using (var client = new ServiceProxy<IIcelandicOnlineBankingClaimServiceChannel>())
                {
                    try
                    {
                        var certificate = (OnlineBankingCertificate)ComboBoxCertificate.SelectedItem;

                        // Add X509 Security token
                        WcfSecurityHelper<IIcelandicOnlineBankingClaimServiceChannel>.SetWcfCertificateCredentials(client, comboBoxUrl.Text, certificate);

                        // Configure Endpoint Identity
                        WcfSecurityHelper<IIcelandicOnlineBankingClaimServiceChannel>.SetEndpointIdentity(client, comboBoxUrl.Text);

                        // Add Message Trace
                        this.AddMessageInspector(client);

                        // Add Username Soap header
                        using (var scope = new OperationContextScope(client.Proxy))
                        {
                            var userHeader = new MessageHeader<string>(UserNameTextBox.Text);
                            var userUntyped = userHeader.GetUntypedHeader("UserName", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(userUntyped);

                            var pwdHeader = new MessageHeader<string>(PasswordTextBox.Password);
                            var pwdUntyped = pwdHeader.GetUntypedHeader("Password", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(pwdUntyped);

                            // Query OperationResult
                            result = client.Proxy.GetClaimOperationResult(id);
                        }
                    }
                    catch (FaultException<IOBSFault> ex)
                    {
                        throw new Exception(this.GetDetailMessage(ex), ex);
                    }
                }
                return result;
            }
            finally
            {
                this.UpdateTrace();
            }
        }

        private ClaimTransaction[] QueryClaimTransactions(string claimant, string account, string dueDate)
        {

            this.ClearTrace();
            Mouse.OverrideCursor = Cursors.Wait;
            var result = default(ClaimTransaction[]);
            try
            {
                // Call GetClaimOperationResult
                using (var client = new ServiceProxy<IIcelandicOnlineBankingClaimServiceChannel>())
                {
                    try
                    {
                        var certificate = (OnlineBankingCertificate)ComboBoxCertificate.SelectedItem;

                        // Add X509 Security token
                        WcfSecurityHelper<IIcelandicOnlineBankingClaimServiceChannel>.SetWcfCertificateCredentials(client, comboBoxUrl.Text, certificate);

                        // Configure Endpoint Identity
                        WcfSecurityHelper<IIcelandicOnlineBankingClaimServiceChannel>.SetEndpointIdentity(client, comboBoxUrl.Text);

                        // Add Message Trace
                        this.AddMessageInspector(client);

                        // Add Username Soap header
                        using (var scope = new OperationContextScope(client.Proxy))
                        {
                            var userHeader = new MessageHeader<string>(UserNameTextBox.Text);
                            var userUntyped = userHeader.GetUntypedHeader("UserName", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(userUntyped);

                            var pwdHeader = new MessageHeader<string>(PasswordTextBox.Password);
                            var pwdUntyped = pwdHeader.GetUntypedHeader("Password", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(pwdUntyped);

                            // Query Transactions
                            var key = new ClaimKey();
                            key.Claimant = claimant;
                            key.DueDate = DateTime.ParseExact(dueDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                            key.Account = account;
                            var transactionResult = client.Proxy.QueryClaimTransactions(key);

                            if (transactionResult.Transactions != null)
                            {
                                result = transactionResult.Transactions;
                            }
                        }
                    }
                    catch (FaultException<IOBSFault> ex)
                    {
                        throw new Exception(this.GetDetailMessage(ex), ex);
                    }
                }
                return result;
            }
            finally
            {
                this.UpdateTrace();
            }
        }

        private string CreateClaims(Claim[] testClaims)
        {
            this.ClearTrace();
            Mouse.OverrideCursor = Cursors.Wait;
            var result = string.Empty;
            try
            {
                // Call CreateClaims
                using (var client = new ServiceProxy<IIcelandicOnlineBankingClaimServiceChannel>())
                {
                    try
                    {
                        var certificate = (OnlineBankingCertificate)ComboBoxCertificate.SelectedItem;

                        // Add X509 Security token
                        WcfSecurityHelper<IIcelandicOnlineBankingClaimServiceChannel>.SetWcfCertificateCredentials(client, comboBoxUrl.Text, certificate);

                        // Configure Endpoint Identity
                        WcfSecurityHelper<IIcelandicOnlineBankingClaimServiceChannel>.SetEndpointIdentity(client, comboBoxUrl.Text);

                        // Add Message Trace
                        this.AddMessageInspector(client);

                        // Add Username Soap header
                        using (var scope = new OperationContextScope(client.Proxy))
                        {
                            var userHeader = new MessageHeader<string>(UserNameTextBox.Text);
                            var userUntyped = userHeader.GetUntypedHeader("UserName", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(userUntyped);

                            var pwdHeader = new MessageHeader<string>(PasswordTextBox.Password);
                            var pwdUntyped = pwdHeader.GetUntypedHeader("Password", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(pwdUntyped);

                            // Create Claims
                            result = client.Proxy.CreateClaims(testClaims);
                        }
                    }
                    catch (FaultException<IOBSFault> ex)
                    {
                        throw new Exception(this.GetDetailMessage(ex), ex);
                    }
                }
                return result;
            }
            finally
            {
                this.UpdateTrace();
            }
        }

        private string AlterClaims(Claim[] testClaims)
        {
            this.ClearTrace();
            Mouse.OverrideCursor = Cursors.Wait;
            var result = string.Empty;
            try
            {
                // Call AlterClaims
                using (var client = new ServiceProxy<IIcelandicOnlineBankingClaimServiceChannel>())
                {
                    try
                    {
                        var certificate = (OnlineBankingCertificate)ComboBoxCertificate.SelectedItem;

                        // Add X509 Security token
                        WcfSecurityHelper<IIcelandicOnlineBankingClaimServiceChannel>.SetWcfCertificateCredentials(client, comboBoxUrl.Text, certificate);

                        // Configure Endpoint Identity
                        WcfSecurityHelper<IIcelandicOnlineBankingClaimServiceChannel>.SetEndpointIdentity(client, comboBoxUrl.Text);

                        // Add Message Trace
                        this.AddMessageInspector(client);

                        // Add Username Soap header
                        using (var scope = new OperationContextScope(client.Proxy))
                        {
                            var userHeader = new MessageHeader<string>(UserNameTextBox.Text);
                            var userUntyped = userHeader.GetUntypedHeader("UserName", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(userUntyped);

                            var pwdHeader = new MessageHeader<string>(PasswordTextBox.Password);
                            var pwdUntyped = pwdHeader.GetUntypedHeader("Password", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(pwdUntyped);

                            // Alter Claims
                            result = client.Proxy.AlterClaims(testClaims);
                        }
                    }
                    catch (FaultException<IOBSFault> ex)
                    {
                        throw new Exception(this.GetDetailMessage(ex), ex);
                    }
                }
                return result;
            }
            finally
            {
                this.UpdateTrace();
            }
        }

        private string CancelClaims(ClaimKey[] testClaimKeys)
        {
            this.ClearTrace();
            Mouse.OverrideCursor = Cursors.Wait;
            var result = string.Empty;
            try
            {
                // Call AlterClaims
                using (var client = new ServiceProxy<IIcelandicOnlineBankingClaimServiceChannel>())
                {
                    try
                    {
                        var certificate = (OnlineBankingCertificate)ComboBoxCertificate.SelectedItem;

                        // Add X509 Security token
                        WcfSecurityHelper<IIcelandicOnlineBankingClaimServiceChannel>.SetWcfCertificateCredentials(client, comboBoxUrl.Text, certificate);

                        // Configure Endpoint Identity
                        WcfSecurityHelper<IIcelandicOnlineBankingClaimServiceChannel>.SetEndpointIdentity(client, comboBoxUrl.Text);

                        // Add Message Trace
                        this.AddMessageInspector(client);

                        // Add Username Soap header
                        using (var scope = new OperationContextScope(client.Proxy))
                        {
                            var userHeader = new MessageHeader<string>(UserNameTextBox.Text);
                            var userUntyped = userHeader.GetUntypedHeader("UserName", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(userUntyped);

                            var pwdHeader = new MessageHeader<string>(PasswordTextBox.Password);
                            var pwdUntyped = pwdHeader.GetUntypedHeader("Password", Security_Namespace);
                            OperationContext.Current.OutgoingMessageHeaders.Add(pwdUntyped);

                            // Cancel Claims
                            result = client.Proxy.CancelClaims(testClaimKeys);
                        }
                    }
                    catch (FaultException<IOBSFault> ex)
                    {
                        throw new Exception(this.GetDetailMessage(ex), ex);
                    }
                }
                return result;
            }
            finally
            {
                this.UpdateTrace();
            }
        }


        #endregion


        #region UI

        /// <summary>
        /// Hreinsar Trace glugga
        /// </summary>
        private void ClearTrace()
        {
            webBrowserRequestText.Visibility = System.Windows.Visibility.Hidden;
            webBrowserResponseText.Visibility = System.Windows.Visibility.Hidden;
        }

        /// <summary>
        /// Uppfærir Trace glugga
        /// </summary>
        /// <param name="item">The item.</param>
        private void UpdateTrace()
        {
            webBrowserRequestText.Visibility = System.Windows.Visibility.Visible;
            webBrowserResponseText.Visibility = System.Windows.Visibility.Visible;
            if (inspector.RequestMessage != null)
            {
                webBrowserRequestText.NavigateToString(XmlToHtml(inspector.RequestMessage));
            }
            if (inspector.ResponseMessage != null)
            {
                webBrowserResponseText.NavigateToString(XmlToHtml(inspector.ResponseMessage));
            }
        }


        #endregion


        #region Helper Functions

        public static string XmlToHtml(string xml)
        {
            if ((xml == null) || (xml.Trim().Length == 0)) return "";

            var s = new StringReader(Properties.Resources.XMLXSLT);

            var xr = XmlReader.Create(s);
            var xct = new XslCompiledTransform();
            xct.Load(xr);

            var sb = new StringBuilder();
            var xw = XmlWriter.Create(sb);

            var tr = new StringReader(xml);
            var xmlData = XmlReader.Create(tr);
            xct.Transform(xmlData, xw);

            return sb.ToString();
        }


        private Claim[] CreateTestClaims(int numberOfClaims, string claimant, string payor, string bank, string identififer)
        {
            var claims = new Claim[Convert.ToInt32(numberOfClaims)];
            var r = new Random();
            var number = string.Empty;
            for (int i = 0; i < claims.Length; i++)
            {
                number = r.Next(111111, 999999).ToString();
                var claim = this.CreateOneTestClaim(claimant, payor, bank, number, identififer);
                claims[i] = claim;
            }
            return claims;
        }

        private Claim CreateOneTestClaim(string claimant, string payor, string bank, string accountNumber, string identififer)
        {
            Claim claim = new Claim();
            Random random = new Random();

            DateTime date = DateTime.Now;
            //Lykill 
            claim.Key = new ClaimKey();

            claim.Key.Claimant = claimant;
            claim.Key.DueDate = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);

            claim.Key.Account = bank + "66" + accountNumber;

            claim.PayorID = payor;
            claim.CancellationDate = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
            claim.CancellationDate = claim.CancellationDate.AddDays(3);

            claim.FinalDueDate = claim.Key.DueDate;
            claim.BillNumber = "1234567";
            claim.OtherCosts = 5;
            claim.OtherDefaultCosts = 10;
            claim.PermitOutOfSequencePayment = false;
            claim.IsPartialPaymentAllowed = false;


            claim.NoticeAndPaymentFee = new NoticeAndPaymentFee();
            claim.NoticeAndPaymentFee.Printing = 0m;
            claim.NoticeAndPaymentFee.Paperless = 0m;

            claim.Identifier = identififer;
            claim.Reference = payor;
            claim.CustomerNumber = payor;

            claim.DefaultCharge = new DateRestrictedCharge();
            claim.DefaultCharge.ReferenceDate = ReferenceDate.DueDate;
            claim.DefaultCharge.First = new DiscountOrDefaultChargeAmount();
            claim.DefaultCharge.First.Days = 30;
            claim.DefaultCharge.First.Value = (decimal)random.Next(200, 500);
            claim.DefaultCharge.Second = new DiscountOrDefaultChargeAmount();
            claim.DefaultCharge.Second.Days = 60;
            claim.DefaultCharge.Second.Value = (decimal)random.Next(500, 1000);

            claim.Discount = new DiscountCharge();
            claim.Discount.ReferenceDate = ReferenceDate.FinalDueDate;
            claim.Discount.IsPostRefDate = false;
            claim.Discount.First = new DiscountOrDefaultChargePercentage();
            claim.Discount.First.Days = 6;
            claim.Discount.First.Value = (decimal)random.Next(10, 20);
            claim.Discount.Second = new DiscountOrDefaultChargePercentage();
            claim.Discount.Second.Days = 3;
            claim.Discount.Second.Value = (decimal)random.Next(5, 10);

            claim.DefaultInterest = new DefaultInterest();
            claim.DefaultInterest.Percentage4 = 0;
            claim.DefaultInterest.Rule = DefaultInterestRule.DefaultInterestAmount;

            claim.BillPresentmentSystem = new BillPresentmentSystem();
            claim.BillPresentmentSystem.Type = "A";
            claim.BillPresentmentSystem.Parameters = "tt";

            claim.Printing = new Printing();
            claim.Printing.PayorAddress = new Address();
            claim.Printing.PayorAddress.Name = "Stinni Stuð";
            claim.Printing.PayorAddress.AddressLine1 = "Stinnahlíð 15";
            claim.Printing.PayorAddress.AddressLine2 = "v/Stuðhlíð";
            claim.Printing.PayorAddress.City = "Reykjavík";
            claim.Printing.PayorAddress.PostalCode = "101";
            claim.Printing.PayorAddress.Country = "IS";

            claim.Printing.ItemRows = new ItemRow[1];
            claim.Printing.ItemRows[0] = new ItemRow();
            claim.Printing.ItemRows[0].Amount = 10;
            claim.Printing.ItemRows[0].Text = "Innheimta";

            claim.Amount = claim.Printing.ItemRows[0].Amount;

            return claim;
        }


        internal string GetDetailMessage(FaultException<IOBSFault> ex)
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
                message += "General source code:  " + ex.Detail.GeneralSourceCode + "\n";
                message += "General source text:  " + ex.Detail.GeneralSourceText + "\n";
            }
            return message;
        }

        internal void AddMessageInspector(ServiceProxy<IIcelandicOnlineBankingClaimServiceChannel> client)
        {
            var currentInspector = client.Endpoint.Behaviors.Find<MessageViewerInspector>();
            if (currentInspector == null)
            {
                client.Endpoint.Behaviors.Add(inspector);
            }
        }

        #endregion 

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var certificateList = OnlineBankingCertificate.GetCertificates(false);
            _certs = new BindingList<object>();
            foreach (var certificate in certificateList)
            {
                _certs.Add(certificate);
            }
            _certs.Insert(0, new EmptyCertificateItem());  // Ensure "None" item is always first
            ComboBoxCertificate.DisplayMemberPath = "DisplayName";
            ComboBoxCertificate.SelectedValuePath = "Subject";
            DataContext = this;  // set datacontext
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnCreateClaims_Click(object sender, RoutedEventArgs e)
        {
            btnCreateClaims.IsEnabled = false;
            Mouse.OverrideCursor = Cursors.Wait;
            var result = string.Empty;
            try
            {
                Dispatcher.Invoke(
                    DispatcherPriority.Background,
                    (Action)delegate ()
                    {
                        var numberOfClaims = Int32.Parse(txtNumberOfClaims.Text);
                        var testClaims = this.CreateTestClaims(numberOfClaims, txtClaimant.Text, txtPayor.Text, txtBank.Text, txtIdentifier.Text);
                        result = this.CreateClaims(testClaims);
                        tabClaimOperationResult.Focus();
                        txtId.Text = result;
                        btnSearch.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    }
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to create claims: " + ex.Message);
            }
            finally
            {
                btnCreateClaims.IsEnabled = true;
                Mouse.OverrideCursor = null;
            }
        }

        private void queryClaimsDataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.queryClaimsDataGrid1.SelectedItems != null)
            {
                btnAlterSelected.IsEnabled = true;
            }
            else
            {
                btnAlterSelected.IsEnabled = false;
            }
        }

        private void btnAlterSelected_Click(object sender, RoutedEventArgs e)
        {
            if (this.queryClaimsDataGrid1.SelectedItems != null)
            {
                alterClaimsDataGrid1.DataContext = this.queryClaimsDataGrid1.SelectedItems;
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            txtBatchResultId.Text = string.Empty;
            txtBatchResultStatus.Text = string.Empty;
            successGrid.DataContext = null;
            errorsGrid.DataContext = null;
            Mouse.OverrideCursor = Cursors.Wait;
            btnSearch.IsEnabled = false;
            var result = default(ClaimOperationResult);
            try
            {
                Dispatcher.Invoke(
                    DispatcherPriority.Background,
                    (Action)delegate ()
                    {
                        result = this.GetClaimOperationResult(txtId.Text);
                        successGrid.DataContext = result.Success;
                        errorsGrid.DataContext = result.Errors;
                        txtBatchResultId.Text = result.ID;
                        txtBatchResultStatus.Text = result.Status.ToString();
                    }
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to find operation result: " + ex.Message);
            }
            finally
            {
                btnSearch.IsEnabled = true;
                Mouse.OverrideCursor = null;
            }
        }


        private void btnQueryClaimTransactions_Click(object sender, RoutedEventArgs e)
        {
            queryClaimsTransactionsDataGrid1.DataContext = null;
            Mouse.OverrideCursor = Cursors.Wait;
            btnQueryClaimTransactions.IsEnabled = false;
            try
            {
                Dispatcher.Invoke(
                    DispatcherPriority.Background,
                    (Action)delegate ()
                    {
                        queryClaimsTransactionsDataGrid1.DataContext = this.QueryClaimTransactions(txtTransactionClaimant.Text, txtTransactionAccount.Text, txtTransactionDueDate.Text);
                    }
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to get claim transactions due to: " + ex.Message);
            }
            finally
            {
                btnQueryClaimTransactions.IsEnabled = true;
                Mouse.OverrideCursor = null;
            }
        }

        private void btnCancelClaims_Click(object sender, RoutedEventArgs e)
        {
            if (this.alterClaimsDataGrid1.SelectedItems != null)
            {
                var claimKeys = this.alterClaimsDataGrid1.SelectedItems.Cast<Claim>().Select(selectedClaim => selectedClaim.Key);
                Mouse.OverrideCursor = Cursors.Wait;
                btnAlterClaims.IsEnabled = false;
                try
                {
                    Dispatcher.Invoke(
                        DispatcherPriority.Background,
                        (Action)
                        (
                            () => this.CancelClaims(claimKeys.ToArray())
                        ));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to get cancel claims due to: " + ex.Message);
                }
                finally
                {
                    btnAlterClaims.IsEnabled = true;
                    Mouse.OverrideCursor = null;
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtTransactionDueDate_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void btnAlterClaims_Click(object sender, RoutedEventArgs e)
        {
            if (this.alterClaimsDataGrid1.SelectedItems != null)
            {
                var claims = new List<Claim>();
                foreach (var selectedClaim in this.alterClaimsDataGrid1.SelectedItems.Cast<Claim>())
                {
                    selectedClaim.Amount = decimal.Parse(txtAlterAmount.Text);
                    selectedClaim.Printing = new Printing();
                    selectedClaim.Printing.ItemRows = new ItemRow[1];
                    selectedClaim.Printing.ItemRows[0] = new ItemRow
                    {
                        Amount = selectedClaim.Amount,
                        Text = "Innborgun"
                    };
                    claims.Add(selectedClaim);
                }
                Mouse.OverrideCursor = Cursors.Wait;
                btnAlterClaims.IsEnabled = false;
                try
                {
                    Dispatcher.Invoke(
                        DispatcherPriority.Background,
                        (Action)
                        (
                            () => this.AlterClaims(claims.ToArray())
                        ));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to alter claims due to: " + ex.Message);
                }
                finally
                {
                    btnAlterClaims.IsEnabled = true;
                    Mouse.OverrideCursor = null;
                }
            }
        }
    }
}
