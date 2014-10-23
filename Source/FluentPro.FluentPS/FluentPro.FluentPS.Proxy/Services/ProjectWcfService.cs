using FluentPro.FluentPS.Contracts.Proxies;
using FluentPro.FluentPS.Proxy.Network;
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
            using (var channel = PsiChannelFactory.CreateProjectChannel())
            {
                var projectList = channel.ReadProjectList();
                return new DataSet();
            }
        }
    }
}
