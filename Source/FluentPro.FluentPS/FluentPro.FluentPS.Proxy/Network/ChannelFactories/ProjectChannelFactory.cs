namespace FluentPro.FluentPS.Proxy.Network.ChannelFactories
{
    using FluentPro.FluentPS.Proxy.Wcf;
    using System.ServiceModel;

    public class ProjectChannelFactory : ChannelFactory<ProjectChannel>
    {
        public ProjectChannelFactory()
        {
            Credentials.Windows.AllowedImpersonationLevel = TokenImpersonationLevel.Impersonation;
            Credentials.Windows.AllowNtlm = true;
        }
    }
}
