using FluentPro.FluentPS.Contracts.Constants;
using FluentPro.FluentPS.Psi.Network.Bindings;
using FluentPro.FluentPS.Psi.Network.ChannelFactories;
using FluentPro.FluentPS.Psi.Network.Channels;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace FluentPro.FluentPS.Psi.Network
{
    public class PsiContext
    {
        private static readonly Dictionary<Uri, PsiContext> Contexts = new Dictionary<Uri, PsiContext>();

        private readonly object _lock = new object();

        private readonly PsiWcfBinding _binding;
        private readonly EndpointAddress _address;
        private volatile ProjectPsiChannelFactory _projectPsiChannelFactory;
        private volatile LookupTablePsiChannelFactory _lookupPsiChannelFactory;
        private volatile QueueSystemChannelFactory _queueSystemChannelFactory;

        #region Constructors

        private PsiContext(PsiWcfBinding binding, EndpointAddress address)
        {
            _binding = binding;
            _address = address;
        }

        #endregion // Constructors

        #region Channels

        public IProjectChannel Project
        {
            get { return ProjectChannelFactory.CreateChannel(); }
        }

        public ILookupTableChannel LookupTable
        {
            get { return LookupChannelFactory.CreateChannel(); }
        }

        public IQueueSystemChannel QueueSystem
        {
            get { return QueueSystemChannelFactory.CreateChannel(); }
        }

        #endregion // Channels

        #region PsiContext static factories

        public static PsiContext Get(Uri uri)
        {
            var address = new EndpointAddress(new Uri(uri, Urls.PsiServiceRelativeUrl));
            if (!Contexts.ContainsKey(address.Uri))
            {
                PsiWcfBinding binding = new HttpPsiWcfBinding();
                if (uri.Scheme == Uri.UriSchemeHttps)
                {
                    binding = new HttpsPsiWcfBinding();
                }

                var contex = new PsiContext(binding, address);
                Contexts.Add(address.Uri, contex);
            }

            return Contexts[address.Uri];
        }

        #endregion // PsiContext static factories

        #region Channel factories

        private ProjectPsiChannelFactory ProjectChannelFactory
        {
            get
            {
                if (_projectPsiChannelFactory == null)
                {
                    lock (_lock)
                    {
                        if (_projectPsiChannelFactory == null)
                        {
                            _projectPsiChannelFactory = new ProjectPsiChannelFactory(_binding, _address);
                        }
                    }
                }

                return _projectPsiChannelFactory;
            }
        }

        private LookupTablePsiChannelFactory LookupChannelFactory
        {
            get
            {
                if (_lookupPsiChannelFactory == null)
                {
                    lock (_lock)
                    {
                        if (_lookupPsiChannelFactory == null)
                        {
                            _lookupPsiChannelFactory = new LookupTablePsiChannelFactory(_binding, _address);
                        }
                    }
                }

                return _lookupPsiChannelFactory;
            }
        }

        private QueueSystemChannelFactory QueueSystemChannelFactory
        {
            get
            {
                if (_queueSystemChannelFactory == null)
                {
                    lock (_lock)
                    {
                        if (_queueSystemChannelFactory == null)
                        {
                            _queueSystemChannelFactory = new QueueSystemChannelFactory(_binding, _address);
                        }
                    }
                }

                return _queueSystemChannelFactory;
            }
        }

        #endregion // Channel factories
    }
}
