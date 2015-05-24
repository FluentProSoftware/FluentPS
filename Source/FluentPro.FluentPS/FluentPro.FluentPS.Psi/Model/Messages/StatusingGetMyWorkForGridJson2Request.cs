namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="StatusingGetMyWorkForGridJson2", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", IsWrapped=true)]
    public partial class StatusingGetMyWorkForGridJson2Request {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=0)]
        public JsGridSerializerArguments gridSerializerArgs;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=1)]
        public string gridChangesJson;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=2)]
        public string projectAssignmentsMap;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=3)]
        public System.Guid viewUid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=4)]
        public string timephasedStart;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=5)]
        public string timephasedEnd;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=6)]
        public string currentTime;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=7)]
        public int durationType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=8)]
        public int workType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=9)]
        public int dateFormat;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=10)]
        public bool clearPersistedProperties;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=11)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> rowFilterType;
        
        public StatusingGetMyWorkForGridJson2Request() {
        }
        
        public StatusingGetMyWorkForGridJson2Request(JsGridSerializerArguments gridSerializerArgs, string gridChangesJson, string projectAssignmentsMap, System.Guid viewUid, string timephasedStart, string timephasedEnd, string currentTime, int durationType, int workType, int dateFormat, bool clearPersistedProperties, System.Nullable<int> rowFilterType) {
            this.gridSerializerArgs = gridSerializerArgs;
            this.gridChangesJson = gridChangesJson;
            this.projectAssignmentsMap = projectAssignmentsMap;
            this.viewUid = viewUid;
            this.timephasedStart = timephasedStart;
            this.timephasedEnd = timephasedEnd;
            this.currentTime = currentTime;
            this.durationType = durationType;
            this.workType = workType;
            this.dateFormat = dateFormat;
            this.clearPersistedProperties = clearPersistedProperties;
            this.rowFilterType = rowFilterType;
        }
    }
}