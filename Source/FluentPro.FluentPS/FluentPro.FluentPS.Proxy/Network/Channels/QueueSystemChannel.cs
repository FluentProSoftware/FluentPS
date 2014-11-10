using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using FluentPro.FluentPS.Psi.Interfaces.Psi;

namespace FluentPro.FluentPS.Psi.Network.Channels
{
    public interface QueueSystemChannel : IQueueSystem, IClientChannel
    {
    }
}
