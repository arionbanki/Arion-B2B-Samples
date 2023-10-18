using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Web.Services3.Security.Tokens;
using Microsoft.Web.Services3.Security;
using Microsoft.Web.Services3;
using System.Security.Cryptography.X509Certificates;

namespace IsIT.B2B.Common.Security
{
	public class WseSecurityHelper
	{
		public static void SetSecurity(WebServicesClientProtocol service, OnlineBankingCertificate certificate, string userName, string password)
		{
			bool validCertificate = !certificate.IsEmpty;
			bool validUsername = !string.IsNullOrEmpty(userName);


			if (!validCertificate)
			{
				throw new ArgumentException("Please choose a valid certificate");
			}
			if (!validUsername)
			{
				throw new ArgumentException("Please enter a username");
			}


			X509SecurityToken securityToken = new X509SecurityToken(certificate);
			MessageSignature signature = new MessageSignature(securityToken);
			signature.SignatureOptions = SignatureOptions.IncludeSoapBody;

			service.RequestSoapContext.Security.Tokens.Add(securityToken);
			service.RequestSoapContext.Security.Elements.Add(signature);

			service.SetClientCredential(securityToken);

			UsernameToken userNameToken = new UsernameToken(userName, password, PasswordOption.SendPlainText);
			service.RequestSoapContext.Security.Tokens.Add(userNameToken);
		}
	}
}
