namespace FluentPro.FluentPS.Proxy.Services
{
    using FluentPro.FluentPS.Contracts.Proxies;
    using FluentPro.FluentPS.Proxy.Network;
    using System;
    using System.Data;

    public class ProjectWcfService : IProjectWcfService
    {
        private readonly Uri _pwaUri;

        public ProjectWcfService(Uri pwaUri)
        {
            _pwaUri = pwaUri;
        }

        public DataSet ReadProjectList()
        {
            var psi = Psi.Get(_pwaUri);
            return psi.Project.ReadProjectList();
        }
    }
}
