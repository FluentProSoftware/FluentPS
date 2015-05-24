using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TimeSheetReadTimeSheetSettingsAndPeriodResponse", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", IsWrapped=true)]
    public partial class TimeSheetReadTimeSheetSettingsAndPeriodResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=0)]
        public TimeSheetSettingsAndPeriodDataSet TimeSheetReadTimeSheetSettingsAndPeriodResult;
        
        public TimeSheetReadTimeSheetSettingsAndPeriodResponse() {
        }
        
        public TimeSheetReadTimeSheetSettingsAndPeriodResponse(TimeSheetSettingsAndPeriodDataSet TimeSheetReadTimeSheetSettingsAndPeriodResult) {
            this.TimeSheetReadTimeSheetSettingsAndPeriodResult = TimeSheetReadTimeSheetSettingsAndPeriodResult;
        }
    }
}