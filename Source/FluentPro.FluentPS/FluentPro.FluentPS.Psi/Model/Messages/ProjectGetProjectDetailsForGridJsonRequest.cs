namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProjectGetProjectDetailsForGridJson", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", IsWrapped=true)]
    public partial class ProjectGetProjectDetailsForGridJsonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=0)]
        public string sessionIdToken;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=1)]
        public JsGridSerializerArguments gridSerializerArgs;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=2)]
        public System.Guid projUid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=3)]
        public System.Guid[] subProjUids;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=4)]
        public int storeId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=5)]
        public string changesJson;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=6)]
        public bool firstTaskViewLoad;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=7)]
        public bool showProjectSummaryTask;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=8)]
        public System.Guid viewUid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=9)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> expandSubprojects;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=10)]
        public bool clearPersistedProperties;
        
        public ProjectGetProjectDetailsForGridJsonRequest() {
        }
        
        public ProjectGetProjectDetailsForGridJsonRequest(string sessionIdToken, JsGridSerializerArguments gridSerializerArgs, System.Guid projUid, System.Guid[] subProjUids, int storeId, string changesJson, bool firstTaskViewLoad, bool showProjectSummaryTask, System.Guid viewUid, System.Nullable<bool> expandSubprojects, bool clearPersistedProperties) {
            this.sessionIdToken = sessionIdToken;
            this.gridSerializerArgs = gridSerializerArgs;
            this.projUid = projUid;
            this.subProjUids = subProjUids;
            this.storeId = storeId;
            this.changesJson = changesJson;
            this.firstTaskViewLoad = firstTaskViewLoad;
            this.showProjectSummaryTask = showProjectSummaryTask;
            this.viewUid = viewUid;
            this.expandSubprojects = expandSubprojects;
            this.clearPersistedProperties = clearPersistedProperties;
        }
    }
}