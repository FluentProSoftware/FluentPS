using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PrepareTimesheetLine", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/TimeSheet/", IsWrapped=true)]
    public partial class PrepareTimesheetLineRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/TimeSheet/", Order=0)]
        public System.Guid tsUID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/TimeSheet/", Order=1)]
        public TimesheetDataSet dsDelta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/TimeSheet/", Order=2)]
        public System.Guid[] tlsNeedFill;
        
        public PrepareTimesheetLineRequest()
        {
        }
        
        public PrepareTimesheetLineRequest(System.Guid tsUID, TimesheetDataSet dsDelta, System.Guid[] tlsNeedFill)
        {
            this.tsUID = tsUID;
            this.dsDelta = dsDelta;
            this.tlsNeedFill = tlsNeedFill;
        }
    }
}