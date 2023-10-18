using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel;
namespace IsIT.B2B.Common.Trace
{
    /// <summary>
    /// Provides a custom behavior that allows a client to capture messages and log
    /// them or assist in debugging messages.
    /// http://keithelder.net/2008/01/15/How-to-Get-Around-WCFs-Lack-of-a-Preview-Web/
    /// </summary>    
    public class MessageViewerInspector : IEndpointBehavior, IClientMessageInspector
    {

        #region Properties
        public string RequestMessage { get; set; }
        public string ResponseMessage { get; set; }
        #endregion

        #region IEndpointBehavior Members
        public void AddBindingParameters(ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {

        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            // adds our inspector to the runtime
            clientRuntime.MessageInspectors.Add(this);
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {

        }

        public void Validate(ServiceEndpoint endpoint)
        {

        }
        #endregion

        #region IClientMessageInspector Members
        void IClientMessageInspector.AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            this.ResponseMessage = reply.ToString();
        }

        object IClientMessageInspector.BeforeSendRequest(ref System.ServiceModel.Channels.Message request, IClientChannel channel)
        {
            this.RequestMessage = request.ToString();
            return null;
        }
        #endregion
    }    
}
