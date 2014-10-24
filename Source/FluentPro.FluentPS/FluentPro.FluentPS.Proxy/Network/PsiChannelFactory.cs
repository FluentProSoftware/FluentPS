using FluentPro.FluentPS.Proxy.Network.Behaviors;
using FluentPro.FluentPS.Proxy.Network.Bindings;
using FluentPro.FluentPS.Proxy.Wcf;
using System.Security.Principal;
using System.ServiceModel;

namespace FluentPro.FluentPS.Proxy.Network
{
    public class PsiChannelFactory
    {
        private static readonly object _projectChannelFactoryLock = new object();

        private static ChannelFactory<ProjectChannel> _projectChannelFactory;

        private static ChannelFactory<ProjectChannel> ProjectChannelFactory
        {
            get
            {
                if (_projectChannelFactory == null)
                {
                    lock (_projectChannelFactoryLock)
                    {
                        if (_projectChannelFactory == null)
                        {
                            _projectChannelFactory = new ChannelFactory<ProjectChannel>(new HttpPsiWcfBinding(), new EndpointAddress("http://udav/pwa/_vti_bin/PSI/ProjectServer.svc"));
                            _projectChannelFactory.Credentials.Windows.AllowedImpersonationLevel = TokenImpersonationLevel.Impersonation;
                            _projectChannelFactory.Credentials.Windows.AllowNtlm = true;
                            _projectChannelFactory.Endpoint.Behaviors.Add(new MaxFaultSizeBehavior());
                        }
                    }
                }

                return _projectChannelFactory;
            }
        }

        public static ProjectChannel CreateProjectChannel()
        {
            return ProjectChannelFactory.CreateChannel();
        }
    }
}
