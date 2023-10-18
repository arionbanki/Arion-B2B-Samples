using System;
using System.ServiceModel;
using System.Linq;
using System.Xml.Linq;
using System.Net;

namespace IsIT.B2B.Common
{
    /// <summary>
    /// WCF Client Proxy IDisposable - Generic WCF Service Proxy: http://blog.weminuche.net/2008/08/test-post.html
    /// Generic WCF Client: http://www.traviswhidden.com/PublicBlog/tabid/358/EntryId/415/Generic-WCF-Client.aspx    
    /// </summary>
    /// <typeparam name="TInterface"></typeparam>
    public class ServiceProxy<TInterface> : ClientBase<TInterface>, IDisposable where TInterface : class
    {
        /// <summary>
        /// Keeps object away being dispoed twise.
        /// </summary>
        private bool disposed = false;

        public delegate void ServiceProxyDelegate<T>(TInterface proxy);
                
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProxy&lt;TInterface&gt;"/> class.
        /// </summary>
        public ServiceProxy()

            : base(typeof(TInterface).ToString())
        {            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProxy&lt;TInterface&gt;"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        public ServiceProxy(string endpointConfigurationName)

            : base(endpointConfigurationName)
        {
        }

        protected override TInterface CreateChannel()
        {
            return this.ChannelFactory.CreateChannel();
        }
             
        public TInterface Proxy
        {
            get
            {
                return this.Channel;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        public void Dispose(bool disposing)
        {            
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (this.State == CommunicationState.Faulted)
                    {                        
                        Abort();
                    }
                    else
                    {
                        try
                        {
                            this.InnerChannel.Close();
                        }
                        catch
                        {
                            Abort();
                        }
                    }
                }
            }            
        }
    }
}
