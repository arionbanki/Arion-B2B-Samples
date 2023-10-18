using System;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.Net.Security;
using System.Configuration;
using System.ServiceModel.Security;

namespace IsIT.B2B.Common.Security
{
    /// <summary>
    /// Setting ProtectionLevel from config file
    /// https://raw.github.com/gtkrug/gfipm-ws-ms.net/master/Model1/Common/ProtectionLevelConfig.cs
    /// 
    /// <![CDATA[
    /// <behaviors>
    ///   <endpointBehaviors>
    ///     <behavior name=“endpointSecurityConfig“>
    ///       <protectionLevel level=“Sign“/>
    /// 
    /// ]]>
    /// 
    /// </summary>
    public class ProtectionLevelBehaviorElement : BehaviorExtensionElement
    {
        public ProtectionLevelBehaviorElement()
        {
        }
        public override Type BehaviorType
        {
            get { return typeof(ProtectionLevelBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new ProtectionLevelBehavior(this.Level);
        }

        [ConfigurationProperty("level")]
        public ProtectionLevel Level
        {
            get
            {
                return (ProtectionLevel)base["level"];
            }
            set
            {
                base["level"] = value;
            }
        }

        ConfigurationPropertyCollection properties = null;
        protected override ConfigurationPropertyCollection Properties
        {
            get
            {
                if (this.properties == null)
                {
                    ConfigurationPropertyCollection propertys = new ConfigurationPropertyCollection();
                    propertys.Add(new ConfigurationProperty("level", typeof(ProtectionLevel), null, ConfigurationPropertyOptions.IsRequired));
                    this.properties = propertys;
                }
                return this.properties;
            }
        }

    }

    public class ProtectionLevelBehavior : IEndpointBehavior
    {
        ProtectionLevel level;

        public ProtectionLevel Level
        {
            get { return level; }
            set { level = value; }
        }

        public ProtectionLevelBehavior()
        {
        }

        internal ProtectionLevelBehavior(ProtectionLevel level)
        {
            this.level = level;
        }
        #region IEndpointBehavior Members

        public void AddBindingParameters(ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {

            var proReq =
                bindingParameters.Remove<ChannelProtectionRequirements>();

            proReq = new ChannelProtectionRequirements();

            MessagePartSpecification unProtectedSpec = new MessagePartSpecification();
            MessagePartSpecification protectedSpec = new MessagePartSpecification(true);

            // I'm setting same protection level for all the actions.
            // You could specify different protection level per action, if required. 
            // Also note, I haven't implemented any support for custom SOAP headers.
            // However that can easily be added using the same mechansim.
            switch (level)
            {
                case ProtectionLevel.None:
                    proReq.OutgoingSignatureParts.AddParts(unProtectedSpec, "*");
                    proReq.IncomingSignatureParts.AddParts(unProtectedSpec, "*");

                    proReq.OutgoingEncryptionParts.AddParts(unProtectedSpec, "*");
                    proReq.IncomingEncryptionParts.AddParts(unProtectedSpec, "*");
                    break;
                case ProtectionLevel.Sign:
                    proReq.OutgoingSignatureParts.AddParts(protectedSpec, "*");
                    proReq.IncomingSignatureParts.AddParts(protectedSpec, "*");

                    proReq.OutgoingEncryptionParts.AddParts(unProtectedSpec, "*");
                    proReq.IncomingEncryptionParts.AddParts(unProtectedSpec, "*");
                    break;
                case ProtectionLevel.EncryptAndSign:
                    proReq.OutgoingSignatureParts.AddParts(protectedSpec, "*");
                    proReq.IncomingSignatureParts.AddParts(protectedSpec, "*");

                    proReq.OutgoingEncryptionParts.AddParts(protectedSpec, "*");
                    proReq.IncomingEncryptionParts.AddParts(protectedSpec, "*");
                    break;
            }
            // Add our protection requirement for this endpoint into the binding params.

            bindingParameters.Add(proReq);
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime)
        {
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher)
        {
        }

        public void Validate(ServiceEndpoint endpoint)
        {
        }
        #endregion
    }
}
