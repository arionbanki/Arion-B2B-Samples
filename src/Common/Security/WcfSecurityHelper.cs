// -----------------------------------------------------------------------
// <copyright file="WcfSecurityHelper.cs" company="Arion Banki">
// Copyright © 2012 Arion banki hf.
// </copyright>
// <author>Eiríkur Haraldsson</author>
// -----------------------------------------------------------------------

using System.ServiceModel.Security;
using System.ServiceModel.Security.Tokens;

namespace IsIT.B2B.Common.Security
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ServiceModel;
    using System.Xml.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Net;
    using System.ServiceModel.Channels;

    /// <summary>
    /// WCF Security Helper
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class WcfSecurityHelper<T> where T : class
    {
        /// <summary>
        /// Sets the WCF certificate security.
        /// </summary>
        /// <param name="proxy">The proxy.</param>
        /// <param name="url">The URL.</param>
        /// <param name="certificate">The certificate.</param>
        /// <param name="useDefaultProxy">if set to <c>true</c> [use default proxy].</param>
        /// <returns></returns>
        public static ServiceProxy<T> SetWcfCertificateCredentials(ServiceProxy<T> proxy, string url, OnlineBankingCertificate certificate, bool useDefaultProxy = false)
        {

          //  proxy.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;           

            // Set Client Certificate
            proxy.ClientCredentials.ClientCertificate.Certificate = certificate;
            //proxy.ClientCredentials.ClientCertificate.SetCertificate(StoreLocation.CurrentUser, StoreName.My, X509FindType.FindBySubjectDistinguishedName, "CN=X,....... OU=\"Undirritun eða auðkenning \", O=IS");

            // Auto Detect Service Certificate
            // This will Download the public key from the wdsl https://ws.b2b.is/Claims/20051201/ClaimService.svc?wsdl
            // This public key could be downloaded seperately once per year (when expires) as .cer file. Instead of downloading it each time.
            proxy.ClientCredentials.ServiceCertificate.DefaultCertificate = GetServerCertificate(url, useDefaultProxy);
            //proxy.ClientCredentials.ServiceCertificate.SetDefaultCertificate = "Better soulution: Find Cert In Store, or load it from database or .cer file";            
            
            return proxy;
        }

        public static void SetEndpointIdentity(ServiceProxy<T> proxy, string url)
        {
            // Setup Identity based on Service Certificate
            proxy.Endpoint.Address = new System.ServiceModel.EndpointAddress(new Uri(url ?? proxy.Endpoint.Address.ToString()), GetIdentityBasedOnDefaultCertificate(proxy.ClientCredentials.ServiceCertificate.DefaultCertificate));            
        }

        /// <summary>
        /// Gets the content of the WSDL as string.
        /// </summary>
        /// <param name="wsdlUrl">The WSDL URL.</param>
        /// <param name="useDefaultProxy">if set to <c>true</c> [use default proxy].</param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        private static string GetWsdlContent(string wsdlUrl, bool useDefaultProxy = false)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    if (useDefaultProxy)
                    {
                        client.Proxy = new WebProxy();
                    }
                    var wsdlContent = client.DownloadString(wsdlUrl);
                    return wsdlContent;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Unable to Download Wsdl, Url:{0}, {1}", wsdlUrl, ex.Message), ex);
            }
        }

        /// <summary>
        /// Gets the server certificate witch is used to sign the Webservice Response.
        /// This downloads the public certificate from ?wsdl url. https://ws.b2b.is/Documents/20130101/DocumentService.svc?wsdl        
        /// if The wsdl url is on a another location 
        /// the url can be discovered by downloading the disco first: https://ws.b2b.is/Documents/20130101/DocumentService.svc?disco
        /// But your would need two http requests for downloading the wsdl that way.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns></returns>
        public static System.Security.Cryptography.X509Certificates.X509Certificate2 GetServerCertificate(string address, bool useDefaultProxy = false)
        {
            System.Security.Cryptography.X509Certificates.X509Certificate2 returnValue = null;
            var wsdlUrl = string.Concat(address, "?wsdl");
            var wsdlContent = GetWsdlContent(wsdlUrl, useDefaultProxy);
            try
            {
                var xmlDoc = XDocument.Parse(wsdlContent);
                var identity = xmlDoc.Descendants(XName.Get("Identity", "http://schemas.xmlsoap.org/ws/2006/02/addressingidentity")).FirstOrDefault();
                if (identity == null)
                {
                    throw new Exception(string.Format("Unable to Parse Identity from Wsdl Content, Url:{0}", wsdlUrl));
                }
                var keyInfo = identity.Element(XName.Get("KeyInfo", "http://www.w3.org/2000/09/xmldsig#"));
                if (keyInfo == null)
                {
                    throw new Exception(string.Format("Unable to Parse keyInfo from Wsdl Content, Url:{0}", wsdlUrl));
                }
                var x509Data = keyInfo.Element(XName.Get("X509Data", "http://www.w3.org/2000/09/xmldsig#"));
                if (x509Data == null)
                {
                    throw new Exception(string.Format("Unable to Parse keyInfo/X509Data from Wsdl Content, Url:{0}", wsdlUrl));
                }
                var x509Certificate = x509Data.Element(XName.Get("X509Certificate", "http://www.w3.org/2000/09/xmldsig#"));
                if (x509Certificate == null)
                {
                    throw new Exception(string.Format("Unable to Parse keyInfo/X509Data/x509Certificate from Wsdl Content, Url:{0}", wsdlUrl));
                }
                var encodedValue = x509Certificate.Value;
                returnValue = new System.Security.Cryptography.X509Certificates.X509Certificate2(Convert.FromBase64String(encodedValue));
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Unable to Parse Wsdl Content, Url:{0}, {1}", wsdlUrl, ex.Message), ex);
            }
            return returnValue;
        }

        /// <summary>
        /// Gets the identity based on default certificate.
        /// Parses the CN= part from the certificate
        /// Create a DnsIdentity for the endpoint
        /// </summary>
        /// <param name="defaultCertificate">The default certificate.</param>
        /// <returns></returns>
        private static EndpointIdentity GetIdentityBasedOnDefaultCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 defaultCertificate)
        {
            var dnsIdentity = defaultCertificate.GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType.SimpleName, false);
            return EndpointIdentity.CreateDnsIdentity(dnsIdentity);
        }

        public static void CreateWcfUserNamePasswordHeaderOnEndpoint(ServiceProxy<T> proxy, string url, string userName, string password, string securityNamespace)
        {
            var endpoint = new EndpointAddress(
                new Uri(url),
                GetIdentityBasedOnDefaultCertificate(proxy.ClientCredentials.ServiceCertificate.DefaultCertificate),
                new[]
                            {
                                AddressHeader.CreateAddressHeader("UserName", securityNamespace, userName),
                                AddressHeader.CreateAddressHeader("Password", securityNamespace, password),
                            }
            );
            proxy.Endpoint.Address = endpoint;
        }

        /// <summary>
        /// Gets the arion mutual certificate binding.
        /// Creates the CustomBinding for Arion IOBWS Security using Code.            
        /// Author: Eiríkur Haraldsson
        /// </summary>        
        /// <returns></returns>
        public static CustomBinding GetArionMutualCertificateBinding(bool useDefaultWebProxy = false)
        {
            var binding = new CustomBinding();
                        
            // Instantiate a binding element that will require MutualCertififcate Security
            // Binding will Sign and Encrypt body and header
            var messageSecurity = SecurityBindingElement.CreateMutualCertificateBindingElement();
            
            //  Specify whether derived keys are required
            messageSecurity.SetKeyDerivation(true);

            // Timestap included in the Soap header
            messageSecurity.IncludeTimestamp = true;

            // This Security version is used because it´s well supported by clients other then Microsoft.
            messageSecurity.MessageSecurityVersion =
                MessageSecurityVersion.
                    WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10;

            // This governs whether the client should detect replays from the server
            messageSecurity.LocalClientSettings.DetectReplays = true;

            // indicates whether replay detection is enabled on the service
            messageSecurity.LocalServiceSettings.DetectReplays = true;

            // Creates a Textmessage encoder
            var textMessage = new TextMessageEncodingBindingElement(MessageVersion.Default, Encoding.UTF8);

            // Recommended values
            textMessage.ReaderQuotas.MaxStringContentLength = Int32.MaxValue;
            textMessage.ReaderQuotas.MaxArrayLength = Int32.MaxValue;
            textMessage.ReaderQuotas.MaxBytesPerRead = Int32.MaxValue;
            textMessage.ReaderQuotas.MaxDepth = Int32.MaxValue;
            textMessage.ReaderQuotas.MaxNameTableCharCount = Int32.MaxValue;

            // Create Transport Element (ClientCertificate is not required on Transport level only message level)
            var httpsTransport = new HttpsTransportBindingElement();
            httpsTransport.RequireClientCertificate = false;
            httpsTransport.UseDefaultWebProxy = useDefaultWebProxy;

            // Recommended values
            httpsTransport.MaxReceivedMessageSize = Int32.MaxValue;
            httpsTransport.MaxBufferPoolSize = Int32.MaxValue;
            
            // Add elements to binding
            binding.Elements.Add(messageSecurity);
            binding.Elements.Add(textMessage);
            binding.Elements.Add(httpsTransport);

            return binding;
        }

        /// <summary>
        /// Gets the arion mutual certificate binding.
        /// Creates the CustomBinding for IOBWS 20131015 Security using Code.            
        /// Author: Eiríkur Haraldsson
        /// </summary>        
        /// <returns></returns>
        public static CustomBinding GetSchema20131015MutualCertificateBinding(bool useDefaultWebProxy = false)
        {
            var binding = new CustomBinding();

            // Use SSL
            var httpsTransport = new HttpsTransportBindingElement();
            httpsTransport.UseDefaultWebProxy = useDefaultWebProxy;
            httpsTransport.RequireClientCertificate = false;
            httpsTransport.MaxReceivedMessageSize = Int32.MaxValue;
            httpsTransport.MaxBufferPoolSize = Int32.MaxValue;

            // Creates a Soap 12 Textmessage encoder
            var textMessage = new TextMessageEncodingBindingElement(MessageVersion.Soap12WSAddressing10, Encoding.UTF8);
            textMessage.ReaderQuotas.MaxStringContentLength = Int32.MaxValue;
            textMessage.ReaderQuotas.MaxArrayLength = Int32.MaxValue;
            textMessage.ReaderQuotas.MaxBytesPerRead = Int32.MaxValue;
            textMessage.ReaderQuotas.MaxDepth = Int32.MaxValue;
            textMessage.ReaderQuotas.MaxNameTableCharCount = Int32.MaxValue;

            // Mutual Certificate
            var initiator = new X509SecurityTokenParameters(X509KeyIdentifierClauseType.Thumbprint, SecurityTokenInclusionMode.AlwaysToRecipient);
            var recipient = new X509SecurityTokenParameters(X509KeyIdentifierClauseType.Thumbprint, SecurityTokenInclusionMode.Never);
            var messageSecurity = new AsymmetricSecurityBindingElement(recipient, initiator);

            // Configure Security Settings
            // Remove DerivedKeyToken 
            messageSecurity.SetKeyDerivation(false);
            // Include Timestamp in Security Header
            messageSecurity.IncludeTimestamp = true;
            // Process BinarySecurityToken
            messageSecurity.AllowSerializedSigningTokenOnReply = true;
            // Encrypt Signature: False
            messageSecurity.MessageProtectionOrder = MessageProtectionOrder.SignBeforeEncrypt;

            // Add Policies
            messageSecurity.MessageSecurityVersion = MessageSecurityVersion.WSSecurity11WSTrust13WSSecureConversation13WSSecurityPolicy12;

            // This governs whether the client should detect replays from the server
            messageSecurity.LocalClientSettings.DetectReplays = true;

            // indicates whether replay detection is enabled on the service
            messageSecurity.LocalServiceSettings.DetectReplays = true;

            // Add elements to binding
            binding.Elements.Add(messageSecurity);
            binding.Elements.Add(textMessage);
            binding.Elements.Add(httpsTransport);

            return binding;
        }

    }
}
