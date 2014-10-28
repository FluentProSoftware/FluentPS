namespace FluentPro.FluentPS.Psi.Services
{
    using System;
    using System.Data;
    using Contracts.Proxies;

    public class ProjectWcfService : IProjectWcfService
    {
        private readonly Uri _pwaUri;

        public ProjectWcfService(Uri pwaUri)
        {
            _pwaUri = pwaUri;
        }

        public DataSet ReadProjectList()
        {
            var psi = Psi.Network.Psi.Get(_pwaUri);
            return psi.Project.ReadProjectList();
        }
    }
}
