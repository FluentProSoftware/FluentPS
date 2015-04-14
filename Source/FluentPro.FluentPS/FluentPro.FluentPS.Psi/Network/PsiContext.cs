using FluentPro.FluentPS.Psi.Network.Channels;
using FluentPro.FluentPS.Psi.Network.Types;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FluentPro.FluentPS.Psi.Network
{
    public class PsiContext
    {
        //TODO: Make this collection thread-safe, as well as other members of this class.
        private static readonly Dictionary<Uri, PsiContext> CachedContexts = new Dictionary<Uri, PsiContext>();

        private readonly Uri _pwaUri;

        private PsiService<IProjectChannel> _project;
        private PsiService<ILookupTableChannel> _lookup;
        private PsiService<IQueueSystemChannel> _queue;

        #region Constructors

        private PsiContext(Uri pwaUri)
        {
            _pwaUri = pwaUri;
        }

        #endregion // Constructors

        #region Services

        public PsiService<IProjectChannel> Project
        {
            get { return _project ?? (_project = new PsiService<IProjectChannel>(_pwaUri)); }
        }

        public PsiService<ILookupTableChannel> LookupTable
        {
            get { return _lookup ?? (_lookup = new PsiService<ILookupTableChannel>(_pwaUri)); }
        }

        public PsiService<IQueueSystemChannel> QueueSystem
        {
            get { return _queue ?? (_queue = new PsiService<IQueueSystemChannel>(_pwaUri)); }
        }

        #endregion // Services

        #region PsiContext static factories

        public static PsiContext Get(Uri uri)
        {
            Trace.TraceInformation("PsiContext for {0} requested. Looking in cache...", uri);
            if (!CachedContexts.ContainsKey(uri))
            {
                Trace.TraceInformation("PsiContext for url {0} not found in cache.", uri);
                CachedContexts.Add(uri, new PsiContext(uri));
                Trace.TraceInformation("New PsiContext for url {0} created and added to cache.", uri);
            }

            Trace.TraceInformation("PsiContext for endpoint {0} returned from cache.", uri);
            return CachedContexts[uri];
        }

        #endregion // PsiContext static factories
    }
}
