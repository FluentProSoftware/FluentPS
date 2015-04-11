using FluentPro.FluentPS.Contracts.Constants;
using FluentPro.FluentPS.Psi.Network.Bindings;
using FluentPro.FluentPS.Psi.Network.ChannelFactories;
using FluentPro.FluentPS.Psi.Network.Channels;
using FluentPro.FluentPS.Psi.Network.Types;
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

        private volatile PsiService<IProjectChannel> _project;
        private volatile PsiService<ILookupTableChannel> _lookup;
        private volatile PsiService<IQueueSystemChannel> _queue;

        #region Constructors

        private PsiContext(PsiWcfBinding binding, EndpointAddress address)
        {
            _binding = binding;
            _address = address;
        }

        #endregion // Constructors

        #region Services

        public PsiService<IProjectChannel> Project
        {
            get { return _project ?? (_project = GetService<IProjectChannel>()); }
        }

        public PsiService<ILookupTableChannel> LookupTable
        {
            get { return _lookup ?? (_lookup = GetService<ILookupTableChannel>()); }
        }

        public PsiService<IQueueSystemChannel> QueueSystem
        {
            get { return _queue ?? (_queue = GetService<IQueueSystemChannel>()); }
        }

        #endregion // Services

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

        private PsiService<TChannel> GetService<TChannel>() where TChannel : IClientChannel
        {
            lock (_lock)
            {
                var channelFactory = new PsiChannelFactory<TChannel>(_binding, _address);
                return new PsiService<TChannel>(channelFactory);
            }
        }
    }
}
