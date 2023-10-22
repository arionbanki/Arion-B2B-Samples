using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
using System.Collections;

namespace IsIT.B2B.Common.Security
{
    [DataObject]
    [Bindable(true, BindingDirection.OneWay)]
    [ReadOnly(true)]
    public class OnlineBankingCertificate : X509Certificate2
    {
        private bool emptyCertificate = false;
        public OnlineBankingCertificate()
        {
            emptyCertificate = true;
        }

        public OnlineBankingCertificate(X509Certificate certificate) : base(certificate)
        {
            emptyCertificate = false;
        }


        public string DisplayName
        {
            get
            {
                if (!emptyCertificate)
                {
                    string displayName = this.FriendlyName;
                    if (string.IsNullOrEmpty(displayName))
                    {
                        displayName = this.Subject;
                    }
                    return displayName;
                }
                else
                {
                    return "<none>";
                }
            }
        }

        /*public override string ToString()
		{
			return DisplayName;
		}*/
        [Browsable(false)]
        public bool IsEmpty
        {
            get
            {
                return emptyCertificate;
            }
        }


        public static BindingList<OnlineBankingCertificate> GetCertificates(bool IsEmptyCertificate = true)
        {
            X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);

            BindingList<OnlineBankingCertificate> certificates = new BindingList<OnlineBankingCertificate>();
            try
            {

                // Add an empty certificate item if IsEmptyCertificate is true
                if (IsEmptyCertificate)
                {
                    certificates.Add(new OnlineBankingCertificate());
                }              

                store.Open(OpenFlags.ReadOnly);
                X509CertificateCollection certs = store.Certificates;
                if (certs != null)
                {
                    foreach (X509Certificate cert in certs)
                    {
                        if (cert.Issuer.ToUpper().Contains("O=AUDKENNI"))
                        {
                            certificates.Add(new OnlineBankingCertificate(cert));
                        }
                    }
                }
            }
            finally
            {
                if (store != null)
                {
                    store.Close();
                }
            }
            return certificates;
        }

        #region ISupportInitialize Members

        public void BeginInit()
        {
        }

        public void EndInit()
        {
        }

        #endregion
    }
}
