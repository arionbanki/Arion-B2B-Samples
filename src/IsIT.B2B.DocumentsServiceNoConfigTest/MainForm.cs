using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Windows.Forms;
using IsIT.B2B.Common;
using IsIT.B2B.Common.Security;
using IsIT.B2B.DocumentsServiceNoConfigTest.DocumentServiceProxy;

namespace IsIT.B2B.DocumentsServiceNoConfigTest
{
    public partial class MainForm : Form
    {
        public const string Security_Namespace = "http://IcelandicOnlineBanking/Security/";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Setup Controls
            this.onlineBankingCertificateBindingSource.DataSource = OnlineBankingCertificate.GetCertificates();            
        }

        private void btnGetDocumentResult_Click(object sender, EventArgs e)
        {

            ClearGetDocumentResult();
            Application.UseWaitCursor = true;
            btnGetDocumentResult.Enabled = false;
            try
            {

                var url = IOBUrlTextBox.Text;

                // Create Binding                
                var useDefaultWebProxyForBinding = checkBoxUseDefaultProxyForServiceFactory.Checked;
                var binding = WcfSecurityHelper<DocumentServiceProxy.IIcelandicOnlineBankingDocumentServiceChannel>.GetArionMutualCertificateBinding(useDefaultWebProxyForBinding);

                // Download Service Certificate from Wsdl
                var useDefaultWebProxy = checkBoxUseProxyforCertDownload.Checked;
                var serviceCertificate = WcfSecurityHelper<DocumentServiceProxy.IIcelandicOnlineBankingDocumentServiceChannel>.GetServerCertificate(url, useDefaultWebProxy);

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
                                
                // Call GetDocumentResult using ChannelFactory instead of ServiceProxy/ClientBase
                // This way no EndpointConfiguration is needed
                using (var factory = new ChannelFactory<DocumentServiceProxy.IIcelandicOnlineBankingDocumentServiceChannel>(binding, endpointAddress))
                {
                    try
                    {                        
                        var certificate = (OnlineBankingCertificate)onlineBankingCertificateBindingSource.Current;
                                                
                        // Configure Client Certificate
                        factory.Credentials.ClientCertificate.Certificate = certificate;

                        // Configure Expected Server Certificate
                        factory.Credentials.ServiceCertificate.DefaultCertificate = serviceCertificate;

                        // Create Request
                        var request = new DocumentServiceProxy.GetDocumentResultRequest();
                        request.Body = new GetDocumentResultRequestBody();
                        request.Body.Query = new DocumentResultQuery();
                        request.Body.Query.DocumentID = textBoxDocumentId.Text;
                                                
                        // Create Channel can also take endpoint Address as parameter
                        var channel = factory.CreateChannel();

                        // Upload Document
                        var response = channel.GetDocumentResult(request);
                        if (response == null || response.Body == null || response.Body.DocumentResult == null)
                        {
                            resultPictureBox.Image = Image.FromFile("Img\\ImageError.png");
                            ShowDocumentResult();
                        }
                        else
                        {
                            resultPictureBox.Image = Image.FromFile("Img\\ImageSuccess.png");
                            ShowDocumentResult(response.Body.DocumentResult);
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
                        btnGetDocumentResult.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Application.UseWaitCursor = false;
                btnGetDocumentResult.Enabled = true;

                // Error in Binding
                MessageBox.Show("Error Creating ServiceFactory: " + ex.Message);
            }
        }

        private string GetDetailMessage(FaultException<IOBSFault> ex)
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

        #region UI

        private void ShowDocumentResult(DocumentResult result = null)
        {
            string message = (result != null) ? "Aðgerð tókst, Staða skjals er " + result.ProcessingStatus.ToString() : "Aðgerð tókst ekki";
            lblGetDocumentResult.Text = message;
        }

        private void ClearGetDocumentResult()
        {
            lblGetDocumentResult.Text = string.Empty;
        }

        #endregion

    }
}
