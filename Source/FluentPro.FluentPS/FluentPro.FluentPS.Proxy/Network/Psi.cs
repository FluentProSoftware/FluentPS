namespace FluentPro.FluentPS.Psi.Network
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using Bindings;
    using ChannelFactories;
    using Channels;

    //TODO: Implement smart cache by url
    public static class Psi
    {
        private static Dictionary<Uri, PsiContext> _contexts = new Dictionary<Uri, PsiContext>();

        public static PsiContext Get(Uri uri)
        {
            var address = new EndpointAddress(new Uri(uri, "_vti_bin/PSI/ProjectServer.svc"));
            if (!_contexts.ContainsKey(address.Uri))
            {
                PsiWcfBinding binding = new HttpPsiWcfBinding();
                if (uri.Scheme == Uri.UriSchemeHttps)
                {
                    binding = new HttpsPsiWcfBinding();
                }

                var contex = new PsiContext(binding, address);
                _contexts.Add(address.Uri, contex);
            }

            return _contexts[address.Uri];
        }
    }

    public class PsiContext
    {
        private readonly PsiWcfBinding _binding;
        private readonly EndpointAddress _address;
        private readonly object _lock = new object();
        private volatile ProjectPsiChannelFactory _projectPsiChannelFactory;
        private volatile LookupTablePsiChannelFactory _lookupPsiChannelFactory;

        public PsiContext(PsiWcfBinding binding, EndpointAddress address)
        {
            _binding = binding;
            _address = address;
        }

        public IProjectChannel Project
        {
            get { return ProjectChannelFactory.CreateChannel(); }
        }

        public ILookupTableChannel LookupTable
        {
            get { return LookupChannelFactory.CreateChannel(); }
        }

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
    }
}
