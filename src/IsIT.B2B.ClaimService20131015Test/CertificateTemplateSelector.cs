using IsIT.B2B.Common.Security;
using System.Windows.Controls;
using System.Windows;


namespace IsIT.B2B.ClaimService20131015Test
{
    public class CertificateTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CertificateTemplate { get; set; }
        public DataTemplate EmptyCertificateTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is OnlineBankingCertificate)
                return CertificateTemplate;
            if (item is EmptyCertificateItem)
                return EmptyCertificateTemplate;
            return base.SelectTemplate(item, container);
        }
    }
}
