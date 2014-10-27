namespace FluentPro.FluentPS.Proxy.Network.ChannelFactories
{
    using FluentPro.FluentPS.Proxy.Network.Channels;
    using FluentPro.FluentPS.Proxy.Wcf;
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    public class LookupTablePsiChannelFactory : PsiChannelFactory<LookupTableChannel>
    {
        public LookupTablePsiChannelFactory(Binding binding, EndpointAddress remoteAddress)
            : base(binding, remoteAddress)
        {
        }
    }
}
