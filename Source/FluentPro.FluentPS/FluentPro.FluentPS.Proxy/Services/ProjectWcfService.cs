using FluentPro.FluentPS.Contracts.Proxies;
using FluentPro.FluentPS.Proxy.Network;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
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
                using (new OperationContextScope(channel))
                {
                    //http://msdn.microsoft.com/en-us/library/ee872368.aspx 
                    WebOperationContext.Current.OutgoingRequest.Headers.Remove("X-FORMS_BASED_AUTH_ACCEPTED");
                    WebOperationContext.Current.OutgoingRequest.Headers.Add("X-FORMS_BASED_AUTH_ACCEPTED", "f");

                    var projectList = channel.ReadProjectList();
                    return new DataSet();
                }
            }
        }
    }
}
