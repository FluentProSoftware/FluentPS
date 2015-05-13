namespace FluentPro.FluentPS.Psi.Network.ChannelFactories
{
    using Behaviors;
    using System.Security.Principal;
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    public class PsiChannelFactory<TChannel> : ChannelFactory<TChannel>
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
