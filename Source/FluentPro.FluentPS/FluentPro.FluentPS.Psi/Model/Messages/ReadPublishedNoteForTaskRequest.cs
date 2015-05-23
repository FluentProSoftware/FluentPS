namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadPublishedNoteForTask", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/Statusing/", IsWrapped=true)]
    public partial class ReadPublishedNoteForTaskRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/Statusing/", Order=0)]
        public System.Guid taskid;
        
        public ReadPublishedNoteForTaskRequest()
        {
        }
        
        public ReadPublishedNoteForTaskRequest(System.Guid taskid)
        {
            this.taskid = taskid;
        }
    }
}