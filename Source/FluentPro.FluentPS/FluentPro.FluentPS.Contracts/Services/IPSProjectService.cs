namespace FluentPro.FluentPS.Contracts.Services
{
    using System.Collections.Generic;

    public interface IPSProjectService<TProject>
    {
        IEnumerable<TProject> GetAll();
    }
}
