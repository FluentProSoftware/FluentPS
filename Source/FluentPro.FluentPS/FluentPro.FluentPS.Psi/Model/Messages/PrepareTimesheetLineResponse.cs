using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PrepareTimesheetLineResponse", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/TimeSheet/", IsWrapped=true)]
    public partial class PrepareTimesheetLineResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/TimeSheet/", Order=0)]
        public TimesheetDataSet dsDelta;
        
        public PrepareTimesheetLineResponse()
        {
        }
        
        public PrepareTimesheetLineResponse(TimesheetDataSet dsDelta)
        {
            this.dsDelta = dsDelta;
        }
    }
}