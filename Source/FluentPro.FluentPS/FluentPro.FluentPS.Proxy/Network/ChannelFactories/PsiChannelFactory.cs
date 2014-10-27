namespace FluentPro.FluentPS.Proxy.Network.ChannelFactories
{
    using FluentPro.FluentPS.Proxy.Network.Behaviors;
    using System.Security.Principal;
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    public class PsiChannelFactory<TChannel> : ChannelFactory<TChannel> where TChannel : IClientChannel
    {
        public PsiChannelFactory(Binding binding, EndpointAddress remoteAddress)
            : base(binding, remoteAddress)
        {
            Credentials.Windows.AllowedImpersonationLevel = TokenImpersonationLevel.Impersonation;
            Credentials.Windows.AllowNtlm = true;
            Endpoint.Behaviors.Add(new MaxFaultSizeBehavior());
        }
    }
}
