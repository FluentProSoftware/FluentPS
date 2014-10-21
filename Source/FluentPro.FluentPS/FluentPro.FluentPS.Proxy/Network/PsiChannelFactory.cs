using FluentPro.FluentPS.Proxy.Network.ChannelFactories;
using FluentPro.FluentPS.Proxy.Wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;

namespace FluentPro.FluentPS.Proxy.Network
{
    public class PsiChannelFactory
    {
        private static readonly object _projectChannelFactoryLock = new object();

        private static readonly ProjectChannelFactory _projectChannelFactory;

        private static ProjectChannelFactory ProjectChannelFactory
        {
            get
            {
                if (_projectChannelFactory == null)
                {
                    lock (_projectChannelFactoryLock)
                    {
                        if (_projectChannelFactory == null)
                        {
                            _projectChannelFactory = new ProjectChannelFactory();
                            return _projectChannelFactory;
                        }
                    }
                }
            }
        }

        public static ProjectChannel CreateProjectChannel()
        {
            return ProjectChannelFactory.CreateChannel();
        }
    }
}
