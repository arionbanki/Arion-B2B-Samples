using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Windows.Forms;
using IsIT.B2B.Common;
using IsIT.B2B.Common.Security;
using IsIT.B2B.DocumentsServiceTest.DocumentServiceProxy;

namespace IsIT.B2B.DocumentsServiceTest
{
    public partial class FrmMainForm : Form
    {
        public const string Security_Namespace = "http://IcelandicOnlineBanking/Security/";

        public FrmMainForm()
        {
            InitializeComponent();
        }

        private void FrmMainForm_Load(object sender, EventArgs e)
        {
            // Setup Controls
            this.onlineBankingCertificateBindingSource.DataSource = OnlineBankingCertificate.GetCertificates();            
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            lblUploadDocumentResult.Text = string.Empty;
            Application.UseWaitCursor = true;
            btnUpload.Enabled = false;            
            try
            {
                // Call UploadDocument
                using (var client = new ServiceProxy<DocumentServiceProxy.IIcelandicOnlineBankingDocumentServiceChannel>())
                {
                    try
                    {
                        // Get Current Selected Certificate from DropDown list
                        var certificate = (OnlineBankingCertificate)onlineBankingCertificateBindingSource.Current;

                        // Add X509 Security token
                        WcfSecurityHelper<DocumentServiceProxy.IIcelandicOnlineBankingDocumentServiceChannel>.SetWcfCertificateCredentials(client, IOBUrlTextBox.Text, certificate);

                        // Add username/password Soap Header
                        WcfSecurityHelper<DocumentServiceProxy.IIcelandicOnlineBankingDocumentServiceChannel>.CreateWcfUserNamePasswordHeaderOnEndpoint(client, IOBUrlTextBox.Text, UserNameTextBox.Text, PasswordTextBox.Text, Security_Namespace);
            
                        // Create Request
                        var request = new DocumentServiceProxy.UploadDocumentRequest();
                        request.Body = new UploadDocumentRequestBody();
                        request.Body.Document = new Document();
                        request.Body.Document.File = File.ReadAllBytes(textBoxFileName.Text);
                        request.Body.Document.DocumentInfo = new DocumentInfo();
                        request.Body.Document.DocumentInfo.DocumentName = textBoxName.Text;
                        request.Body.Document.DocumentInfo.DocumentType = comboBoxTegund.Text;
                        request.Body.Document.DocumentInfo.PersonID = textBoxKennitala.Text;

                        // Upload Document
                        var response = client.Proxy.UploadDocument(request);
                        if (response == null || response.Body == null)
                        {
                            resultPictureBox.Image = Image.FromFile("Img\\ImageError.png");                            
                        }
                        else
                        {
                            resultPictureBox.Image = Image.FromFile("Img\\ImageSuccess.png");
                            lblUploadDocumentResult.Text = response.Body.DocumentID;
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
                        Application.UseWaitCursor = false;
                        btnUpload.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Application.UseWaitCursor = false;
                btnUpload.Enabled = true;

                // Error in Binding or Configuration errors
                MessageBox.Show("Error Creating ServiceProxy: " + ex.Message);
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
        
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblUploadDocumentResult.Text);
        }

        private void btnGetUploadResult_Click(object sender, EventArgs e)
        {
            ClearGetDocumentResult();
            Application.UseWaitCursor = true;            
            btnGetDocumentResult.Enabled = false;
            try
            {
                // Call GetDocumentResult
                using (var client = new ServiceProxy<DocumentServiceProxy.IIcelandicOnlineBankingDocumentServiceChannel>())
                {
                    try
                    {
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

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var result = openFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                textBoxFileName.Text = openFileDialog1.FileName;

                // Set Name = FileName without file extension
                textBoxName.Text = Path.GetFileNameWithoutExtension(textBoxFileName.Text);

                // Select First Type if none is selected
                if (comboBoxTegund.SelectedIndex == -1)
                {
                    comboBoxTegund.SelectedIndex = 0;
                }
            }
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    }
}
