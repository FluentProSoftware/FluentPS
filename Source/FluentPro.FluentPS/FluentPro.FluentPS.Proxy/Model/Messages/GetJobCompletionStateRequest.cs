using System;
using System.Diagnostics;
using System.ServiceModel;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [DebuggerStepThrough]
    [MessageContract(WrapperName = "GetJobCompletionState", WrapperNamespace = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/", IsWrapped = true)]
    public partial class GetJobCompletionStateRequest
    {
        [MessageBodyMember(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/", Order = 0)]
        public Guid jobUID;

        public GetJobCompletionStateRequest()
        {
        }

        public GetJobCompletionStateRequest(Guid jobUID)
        {
            this.jobUID = jobUID;
        }
    }
}
