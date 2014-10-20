using FluentPro.FluentPS.Contracts.Proxies;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace FluentPro.FluentPS.Proxy.Services
{
    public class ProjectWcfService : IProjectWcfService
    {
        public ProjectWcfService()
        {
        }

        public DataSet ReadProjectList()
        {
            throw new NotImplementedException();
        }

        private static void SetClientEndpoints(Uri pwaUri)
        {
            
            //const string svcRouter = "_vti_bin/PSI/ProjectServer.svc";

            //pwaUrl = pwaUri.Scheme + Uri.SchemeDelimiter + pwaUri.Host + ":" + pwaUri.Port + pwaUri.AbsolutePath;
            //Console.WriteLine("URL: {0}", pwaUrl);

        

            //// The endpoint address is the ProjectServer.svc router for all public PSI calls.
            //EndpointAddress address = new EndpointAddress(pwaUrl + svcRouter);

            //projectClient = new backendProject.ProjectClient(binding, address);
            //projectClient.ChannelFactory.Credentials.Windows.AllowedImpersonationLevel = TokenImpersonationLevel.Impersonation;
            //projectClient.ChannelFactory.Credentials.Windows.AllowNtlm = true;

            //queueSystemClient = new backendQueueSystem.QueueSystemClient(binding, address);
            //queueSystemClient.ChannelFactory.Credentials.Windows.AllowedImpersonationLevel = TokenImpersonationLevel.Impersonation;
            //queueSystemClient.ChannelFactory.Credentials.Windows.AllowNtlm = true;
        }
    }
}
