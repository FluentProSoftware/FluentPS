namespace FluentPro.FluentPS.Psi.Network
{
    using Types;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public class PsiContext
    {
        //TODO: Make this collection thread-safe, as well as other members of this class.
        /// <summary>
        /// Cache PsiServices per AppDomain and URI
        /// </summary>
        private static readonly Dictionary<Uri, Dictionary<Type, object>> CachedServices = new Dictionary<Uri, Dictionary<Type, object>>();

        private PsiContext()
        {
        }
        
        /// <summary>
        /// Get service for given pwa uri.
        /// </summary>
        /// <typeparam name="TService">Interface of the service. Can be IProject, IResource, IQueueSystem etc.</typeparam>
        /// <param name="pwaUri">The Project Web App uri, should have slash at the end, for example http://server/pwa/. </param>
        /// <example>
        /// var projectService = PsiContext.Get&lt;IProject&gt;(new Uri("http://server/pwa/"));
        /// var projectDs = projectService.Invoke(p => p.ReadProjectList());
        /// </example>
        /// <returns>PsiService instance.</returns>
        public static PsiService<TService> Get<TService>(Uri pwaUri)
        {
            var channelType = typeof(TService);
            Trace.TraceInformation("PsiService<{0}> for url {1} requested.", channelType.Name, pwaUri);
            if (!CachedServices.ContainsKey(pwaUri))
            {
                Trace.TraceInformation("No Psi services for url {0} found in cache. Create a new entry.", pwaUri);
                CachedServices.Add(pwaUri, new Dictionary<Type, object>());
            }

            var entry = CachedServices[pwaUri];
            if (!entry.ContainsKey(channelType))
            {
                Trace.TraceInformation("PsiService<{0}> for url {1} not found in cache. Create a new PsiService<{0}> and add it to cache.", channelType.Name, pwaUri);
                var psiService = new PsiService<TService>(pwaUri);
                entry.Add(channelType, psiService);
                return psiService;
            }

            Trace.TraceInformation("PsiContext for endpoint {0} returned from cache.", pwaUri);
            return entry[channelType] as PsiService<TService>;
        }
    }
}
