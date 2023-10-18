using System;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;

namespace IsIT.B2B.Common.Security
{
    /// <summary>
    /// Configuration Elmement for MultiFactorAuthBinding
    /// </summary>
    public class CustomMutualCertificateBindingElement : StandardBindingElement
    {
        protected override Type BindingElementType
        {
            get { return typeof(CustomMutualCertificateBinding); }
        }

        protected override void OnApplyConfiguration(Binding binding)
        {

        }
    }
}
