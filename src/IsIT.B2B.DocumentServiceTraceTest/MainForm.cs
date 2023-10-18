using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
using IsIT.B2B.Common;
using IsIT.B2B.Common.Security;
using IsIT.B2B.Common.Trace;
using IsIT.B2B.DocumentServiceTraceTest.DocumentServiceProxy;

namespace IsIT.B2B.DocumentServiceTraceTest
{
    public partial class MainForm : Form
    {
        public const string Security_Namespace = "http://IcelandicOnlineBanking/Security/";

        // 1. Create Message Inspector
        private static readonly MessageViewerInspector inspector = new MessageViewerInspector();

        public MainForm()
        {
            InitializeComponent();
        }


        #region Form Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Setup Controls
            this.onlineBankingCertificateBindingSource.DataSource = OnlineBankingCertificate.GetCertificates();
        }

        private void btnGetDocumentResult_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            btnGetDocumentResult.Enabled = false;
            
            // 2. Clear Trace
            this.ClearTrace();

            try
            {
                // Call GetDocumentResult
                using (var client = new ServiceProxy<DocumentServiceProxy.IIcelandicOnlineBankingDocumentServiceChannel>())
                {
                    try
                    {

                        // 3. Add Message Inspector
                        this.AddMessageInspector(client);

                        var certificate = (OnlineBankingCertificate)onlineBankingCertificateBindingSource.Current;

                        // Add X509 Security token
                        WcfSecurityHelper<DocumentServiceProxy.IIcelandicOnlineBankingDocumentServiceChannel>.SetWcfCertificateCredentials(client, IOBUrlTextBox.Text, certificate);

                        // Add username/password Soap Header
                        WcfSecurityHelper<DocumentServiceProxy.IIcelandicOnlineBankingDocumentServiceChannel>.CreateWcfUserNamePasswordHeaderOnEndpoint(client, IOBUrlTextBox.Text, UserNameTextBox.Text, PasswordTextBox.Text, Security_Namespace);

                        // Create Request
                        var request = new DocumentServiceProxy.GetDocumentResultRequest();
                        request.Body = new GetDocumentResultRequestBody();
                        request.Body.Query = new DocumentResultQuery();
                        request.Body.Query.DocumentID = textBoxDocumentId.Text;

                        // Upload Document
                        var response = client.Proxy.GetDocumentResult(request);
                        if (response == null || response.Body == null || response.Body.DocumentResult == null)
                        {

                        }
                        else
                        {

                        }
                    }
                    catch (FaultException<IOBSFault> ex)
                    {
                        // Closes the channel.
                        client.Close();
                        MessageBox.Show(this.GetDetailMessage(ex));
                    }
                    catch (CommunicationException ex)
                    {
                        // Still no connection to server, so abort is called on the channel.
                        client.Abort();
                        MessageBox.Show((ex.InnerException != null) ? ex.InnerException.Message : ex.Message);
                    }
                    catch (Exception ex)
                    {
                        // Try Close/Abort the channel.                        
                        if (client.State == CommunicationState.Faulted)
                        {
                            client.Abort();
                        }
                        else
                        {
                            try
                            {
                                client.Close();
                            }
                            catch (Exception)
                            {
                            }
                        }
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        // 4. Update Trace
                        this.UpdateTrace();
                        Application.UseWaitCursor = false;
                        btnGetDocumentResult.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Application.UseWaitCursor = false;
                btnGetDocumentResult.Enabled = true;

                // Error in Binding or Configuration errors
                MessageBox.Show("Error Creating ServiceProxy: " + ex.Message);
            }
        }

        #endregion

        #region Error Formatter

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

        #endregion

        #region Trace

        internal void AddMessageInspector(ServiceProxy<DocumentServiceProxy.IIcelandicOnlineBankingDocumentServiceChannel> client)
        {
            var currentInspector = client.Endpoint.Behaviors.Find<MessageViewerInspector>();
            if (currentInspector == null)
            {
                client.Endpoint.Behaviors.Add(inspector);
            }
        }

        /// <summary>
        /// Hreinsar Trace glugga
        /// </summary>
        private void ClearTrace()
        {
            webBrowserRequest.DocumentText = string.Empty;
            webBrowserResponse.DocumentText = string.Empty;
        }

        /// <summary>
        /// Uppfærir Trace glugga
        /// </summary>
        /// <param name="item">The item.</param>
        private void UpdateTrace()
        {
            var item = new MessageTraceItem();
            item.RequestXml = inspector.RequestMessage;
            item.ResponseXml = inspector.ResponseMessage;

            this.UpdateRequestTrace(item.RequestHtml);
            this.UpdateResponseTrace(item.ResponseHtml);
        }

        internal void UpdateRequestTrace(string requestHtml)
        {
            webBrowserRequest.Navigate("about:blank");
            if (webBrowserRequest.Document != null)
            {
                webBrowserRequest.Document.OpenNew(false);
                webBrowserRequest.Document.Write(requestHtml);
            }
            webBrowserRequest.Refresh();
        }

        internal void UpdateResponseTrace(string responseHtml)
        {
            webBrowserResponse.Navigate("about:blank");
            if (webBrowserResponse.Document != null)
            {
                webBrowserResponse.Document.OpenNew(false);
                webBrowserResponse.Document.Write(responseHtml);
            }
            webBrowserResponse.Refresh();
        }

        #endregion

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
