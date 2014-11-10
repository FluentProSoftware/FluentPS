using FluentPro.FluentPS.Psi.Model.Enums;
using System.ServiceModel;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [MessageContract(WrapperName = "GetJobCompletionStateResponse", WrapperNamespace = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/", IsWrapped = true)]
    public partial class GetJobCompletionStateResponse
    {
        [MessageBodyMember(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/", Order = 0)]
        public JobState GetJobCompletionStateResult;

        [MessageBodyMember(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/QueueSystem/", Order = 1)]
        public string errorString;

        public GetJobCompletionStateResponse()
        {
        }

        public GetJobCompletionStateResponse(JobState GetJobCompletionStateResult, string errorString)
        {
            this.GetJobCompletionStateResult = GetJobCompletionStateResult;
            this.errorString = errorString;
        }
    }
}
