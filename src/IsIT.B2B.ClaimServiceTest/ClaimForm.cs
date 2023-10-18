using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IsIT.B2B.ClaimServiceTest.ClaimServiceProxy;
using IsIT.B2B.Common.Security;
using IsIT.B2B.Common;
using IsIT.B2B.Common.Trace;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace IsIT.B2B.ClaimServiceTest
{
    public partial class ClaimForm : Form
    {
        public const string Security_Namespace = "http://IcelandicOnlineBanking/Security/";

        private static readonly MessageViewerInspector inspector = new MessageViewerInspector();

        #region Constructor

        public ClaimForm()
        {
            InitializeComponent();
        }

        #endregion
        
        #region Business Methods

        private ClaimsQuery SetupMultiQuery()
        {
            var query = new ClaimsQuery();
            query.Claimant = _txtQueryClaimClaimant.Text;
            query.Payor = string.IsNullOrEmpty(_txtQueryClaimPayor.Text) ? null : _txtQueryClaimPayor.Text;
            query.Identifier = string.IsNullOrEmpty(_txtQueryClaimIdentifier.Text) ? null : _txtQueryClaimIdentifier.Text;
            if (_cmbQueryClaimStatus.SelectedItem != null)
            {
                query.Status = (ClaimStatus)_cmbQueryClaimStatus.SelectedItem;                
            }
            query.Period = new ClaimsQueryDateSpan();
            query.Period.DateSpanReferenceDate = (DateSpanReferenceDate)_cmbQueryClaimReferenceDate.SelectedItem;
            query.Period.DateFrom = _dtpQueryClaimDateFrom.Value;
            query.Period.DateTo = _dtpQueryClaimDateTo.Value;
            query.RecordFrom = Convert.ToUInt32(_nupQueryClaimEntryFrom.Value);
            query.RecordTo = Convert.ToUInt32(_nupQueryClaimEntryTo.Value);
            return query;
        }

 

        private ClaimInfo[] QueryClaims2013(bool Single)
        {
            ClaimInfo[] claims = null;
            try
            {
                var url = IOBUrlTextBox.Text;

                // Create Binding                
                var useDefaultWebProxyForBinding = checkBoxUseDefaultProxyForServiceFactory.Checked;
                var binding = WcfSecurityHelper<ClaimServiceProxy.IIcelandicOnlineBankingClaimServiceChannel>.GetArionMutualCertificateBinding(useDefaultWebProxyForBinding);

                // Download Service Certificate from Wsdl
                var useDefaultWebProxy = checkBoxUseProxyforCertDownload.Checked;
                var serviceCertificate = WcfSecurityHelper<ClaimServiceProxy.IIcelandicOnlineBankingClaimServiceChannel>.GetServerCertificate(url, useDefaultWebProxy);

                // Create Endpoint Identity based on Service certificate
                var dnsIdentity = serviceCertificate.GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType.SimpleName, false);
                var endpointIdentity = EndpointIdentity.CreateDnsIdentity(dnsIdentity);

                // Create Username and Password Soap Headers
                var authHeaders = new[]
                                      {
                                          AddressHeader.CreateAddressHeader("UserName", Security_Namespace,
                                                                            UserNameTextBox.Text),
                                          AddressHeader.CreateAddressHeader("Password", Security_Namespace,
                                                                            PasswordTextBox.Text),
                                      };

                // Create endpoint
                var endpointAddress = new EndpointAddress(
                     new Uri(url),
                     endpointIdentity,
                     authHeaders
                 );

                // Call QueryClaims using ChannelFactory instead of ServiceProxy/ClientBase
                // This way no EndpointConfiguration is needed
                using (var factory = new ChannelFactory<ClaimServiceProxy.IIcelandicOnlineBankingClaimServiceChannel>(binding, endpointAddress))
                {
                    try
                    {
                        var certificate = (OnlineBankingCertificate)onlineBankingCertificateBindingSource.Current;

                        // Configure Client Certificate
                        factory.Credentials.ClientCertificate.Certificate = certificate;

                        // Configure Expected Server Certificate
                        factory.Credentials.ServiceCertificate.DefaultCertificate = serviceCertificate;


                        // Create Request
                        if (Single)
                        {
                            //Setup Single Query  
                            ClaimKey key = new ClaimKey();
                            key.Claimant = _txtQueryClaimClaimantSingle.Text;
                            key.Account = _txtQueryClaimAccountSingle.Text;
                            key.DueDate = _dtpQueryClaimDueDateSingle.Value;
                            
                            // Create Channel can also take endpoint Address as parameter
                            var channelSingle = factory.CreateChannel();

                            // Query Single Claim
                            Application.DoEvents();
                            var claim = channelSingle.QueryClaim(key);

                            if (claim != null)
                            {
                                claims = new ClaimInfo[1];
                                claims[0] = claim;
                            }

                        }
                        else
                        {
                            //Setup Multi Query
                            ClaimsQuery query = SetupMultiQuery();

                            // Create Channel can also take endpoint Address as parameter
                            var channel = factory.CreateChannel();

                            // Application.DoEvents();
                            // Get claims
                            QueryClaimsResult results = channel.QueryClaims(query);
                            claims = results.Claims;
                        }
                    }
                    catch (FaultException<IOBSFault> ex)
                    {
                        // Closes the channel.
                        factory.Close();
                        MessageBox.Show(this.GetDetailMessage(ex));
                    }
                    catch (CommunicationException ex)
                    {
                        // Still no connection to server, so abort is called on the channel.
                        factory.Abort();
                        MessageBox.Show((ex.InnerException != null) ? ex.InnerException.Message : ex.Message);
                    }
                    catch (Exception ex)
                    {
                        // Try Close/Abort the channel.                        
                        if (factory.State == CommunicationState.Faulted)
                        {
                            factory.Abort();
                        }
                        else
                        {
                            try
                            {
                                factory.Close();
                            }
                            catch (Exception)
                            {
                            }
                        }
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Application.UseWaitCursor = false;
                    }
                }
                return claims;
            }
            catch (Exception ex)
            {
                throw;
            }
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
            }
            return message;
        }

        


        #endregion

        #region UI

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        private DataTable BuildClaimsQueriedDataTable(ClaimInfo[] claims)
        {
            
            DataTable dt = new DataTable("Claims");
            dt.Columns.Add("Claimant", typeof(string));
            dt.Columns.Add("DueDate", typeof(DateTime));
            dt.Columns.Add("FinalDueDate", typeof(DateTime));
            dt.Columns.Add("CancelationDate", typeof(DateTime));
            dt.Columns.Add("Account", typeof(string));
            dt.Columns.Add("Identifier", typeof(string));
            dt.Columns.Add("Payor", typeof(string));
            dt.Columns.Add("Amount", typeof(string));
            dt.Columns.Add("ClaimStatus", typeof(string));

            if (claims != null)
            {
                foreach (ClaimInfo claim in claims)
                {
                    DataRow row = dt.NewRow();
                    row["Claimant"] = claim.Key.Claimant;
                    row["DueDate"] = claim.Key.DueDate;
                    row["FinalDueDate"] = claim.FinalDueDate;
                    row["CancelationDate"] = claim.CancellationDate;
                    row["Account"] = claim.Key.Account;
                    row["Identifier"] = claim.Identifier;
                    row["Payor"] = claim.PayorID;
                    row["Amount"] = claim.Amount;
                    row["ClaimStatus"] = claim.Status.ToString();
                    dt.Rows.Add(row);
                }
                dt.AcceptChanges();
            }
            return dt;
        }

        #endregion

        #region Events

        private void ClaimForm_Load(object sender, EventArgs e)
        {
            // Setup Controls
            this.onlineBankingCertificateBindingSource.DataSource = OnlineBankingCertificate.GetCertificates();

            this._cmbQueryClaimStatus.Items.Add(ClaimStatus.Unpaid);
            this._cmbQueryClaimStatus.Items.Add(ClaimStatus.Paid);
            this._cmbQueryClaimStatus.Items.Add(ClaimStatus.Cancelled);
            this._cmbQueryClaimStatus.Items.Add(ClaimStatus.Invalid);
            this._cmbQueryClaimStatus.SelectedIndex = 0;

            this._cmbQueryClaimReferenceDate.Items.Add(DateSpanReferenceDate.DueDate);
            this._cmbQueryClaimReferenceDate.Items.Add(DateSpanReferenceDate.FinalDueDate);
            this._cmbQueryClaimReferenceDate.Items.Add(DateSpanReferenceDate.CreationDate);
            this._cmbQueryClaimReferenceDate.Items.Add(DateSpanReferenceDate.CancellationDate);
            this._cmbQueryClaimReferenceDate.SelectedIndex = 0;

           

            // Default Claimant
            string defaultClaimant = "1234567890";            
            _txtQueryClaimClaimant.Text = defaultClaimant;
            _txtQueryClaimPayor.Text = defaultClaimant;
            _txtQueryClaimClaimantSingle.Text = defaultClaimant;
        }

        private void _btnQueryClaimSearch_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            _btnQueryClaimSearch.Enabled = false;            
            ClaimInfo[] claims = null;
            try
            {                
                claims = QueryClaims2013(false);
            }
            catch (Exception x)
            {
                ShowErrorMessage("Unable to search for claims due to: " + x.Message);
            }
            finally
            {
                _dgvQueriedClaims.DataSource = this.BuildClaimsQueriedDataTable(claims);
                _btnQueryClaimSearch.Enabled = true;
                Application.UseWaitCursor = false;
            }
        }
        
        #endregion

        private void CertificatesCMB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void _btnQueryClaimSingleSearch_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            _btnQueryClaimSearch.Enabled = false;
            ClaimInfo[] claims = null;
            try
            {
                claims = QueryClaims2013(true);
            }
            catch (Exception x)
            {
                ShowErrorMessage("Unable to search for claims due to: " + x.Message);
            }
            finally
            {
                _dgvQueriedClaims.DataSource = this.BuildClaimsQueriedDataTable(claims);
                _btnQueryClaimSearch.Enabled = true;
                Application.UseWaitCursor = false;
            }

        }
    }
}
