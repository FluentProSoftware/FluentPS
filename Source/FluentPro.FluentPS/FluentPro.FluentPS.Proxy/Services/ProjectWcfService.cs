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
    // Exception when trying to extract PlatformContext from the corresponding message header: System.Runtime.InteropServices.COMException (0x800703FA): Retrieving the COM class factory for component with CLSID {BDEADF26-C265-11D0-BCED-00A0C90AB50F} failed due to the following error: 800703fa Illegal operation attempted on a registry key that has been marked for deletion. (Exception from HRESULT: 0x800703FA).    
    // Exception in LogTimingsToETW: Microsoft.Office.Server.Search.Query.SearchServiceNotFoundException: The search request was unable to connect to the Search Service.    
    //  at Microsoft.Office.Server.Search.Administration.SearchServiceApplicationProxy.GetProxy(SPServiceContext ServiceContext)    
    //  at Microsoft.Office.Server.Search.Query.TraceManager.LogTimingsToETW()
    // http://blogs.msdn.com/b/rdoherty/archive/2006/07/26/678841.aspx
    // Add wiki page about SPN registration.
    // https://social.technet.microsoft.com/Forums/windowsserver/en-US/1262a5f8-20da-4df2-8ced-42529ece89fa/setspn-to-add-spn-results-in-error-8344-insufficient-access-rights?forum=winserverDS
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

                    var projectList = channel.ReadProjectTeam();
                    return new DataSet();
                }
            }
        }
    }
}
