// -----------------------------------------------------------------------
// <copyright file="CustomMutualCertificateBinding.cs" company="Arion Banki">
// Copyright © 2014 Arion banki hf.
// </copyright>
// <author>Eiríkur Haraldsson</author>
// -----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Security;
using System.ServiceModel.Security.Tokens;
using System.Text;

namespace IsIT.B2B.Common.Security
{
    public class CustomMutualCertificateBinding : Binding
    {
        /// <summary>
        /// Binding Class for IOBWS Schema 20131015
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.ICollection`1"/> object of type <see cref="T:System.ServiceModel.Channels.BindingElement"/> that contains the binding elements from the current binding object in the correct order.
        /// </returns>
        public override BindingElementCollection CreateBindingElements()
        {
            var returnValue = new BindingElementCollection();

            // Use SSL
            var httpsTransport = new HttpsTransportBindingElement();
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

            // Mutual Certificate (Asymmmetric no encryption)
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
            
            // Create a CustomBinding based on the constructed security binding element.
            returnValue.Add(messageSecurity);
            returnValue.Add(textMessage);
            returnValue.Add(httpsTransport);
            return returnValue;
        }

        public override string Scheme
        {
            get { return "https"; }
        }
    }
}
