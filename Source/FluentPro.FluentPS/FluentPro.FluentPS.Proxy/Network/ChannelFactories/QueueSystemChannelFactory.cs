using FluentPro.FluentPS.Psi.Network.Channels;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace FluentPro.FluentPS.Psi.Network.ChannelFactories
{
    public class QueueSystemChannelFactory: PsiChannelFactory<IQueueSystemChannel>
    {
        public QueueSystemChannelFactory(Binding binding, EndpointAddress remoteAddress)
            : base(binding, remoteAddress)
        {
        }
    }
}
