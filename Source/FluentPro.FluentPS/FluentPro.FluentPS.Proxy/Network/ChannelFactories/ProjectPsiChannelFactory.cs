using FluentPro.FluentPS.Psi.Network.Channels;

namespace FluentPro.FluentPS.Psi.Network.ChannelFactories
{
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    public class ProjectPsiChannelFactory : PsiChannelFactory<IProjectChannel>
    {
        public ProjectPsiChannelFactory(Binding binding, EndpointAddress remoteAddress)
            : base(binding, remoteAddress)
        {
        }
    }
}
