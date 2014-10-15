namespace FluentPro.FluentPS.Services
{
    using FluentPro.FluentPS.Contracts.Services;
    using System.Collections.Generic;

    public class PSProjectService<TProject> : IPSProjectService<TProject>
    {
        public IEnumerable<TProject> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
