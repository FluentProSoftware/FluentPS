namespace FluentPro.FluentPS.Proxy.Network.ChannelFactories
{
    using FluentPro.FluentPS.Proxy.Network.Channels;
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    public class ProjectPsiChannelFactory : PsiChannelFactory<ProjectChannel>
    {
        public ProjectPsiChannelFactory(Binding binding, EndpointAddress remoteAddress)
            : base(binding, remoteAddress)
        {
        }
    }
}
