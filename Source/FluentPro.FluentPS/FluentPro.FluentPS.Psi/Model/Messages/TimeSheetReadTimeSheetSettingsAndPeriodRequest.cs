namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TimeSheetReadTimeSheetSettingsAndPeriod", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", IsWrapped=true)]
    public partial class TimeSheetReadTimeSheetSettingsAndPeriodRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.Guid> requestedTimeSheetUid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.Guid> requestedTimePeriodUid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> requestedDate;
        
        public TimeSheetReadTimeSheetSettingsAndPeriodRequest() {
        }
        
        public TimeSheetReadTimeSheetSettingsAndPeriodRequest(System.Nullable<System.Guid> requestedTimeSheetUid, System.Nullable<System.Guid> requestedTimePeriodUid, System.Nullable<System.DateTime> requestedDate) {
            this.requestedTimeSheetUid = requestedTimeSheetUid;
            this.requestedTimePeriodUid = requestedTimePeriodUid;
            this.requestedDate = requestedDate;
        }
    }
}