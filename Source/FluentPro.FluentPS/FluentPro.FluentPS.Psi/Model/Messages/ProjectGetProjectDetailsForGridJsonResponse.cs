namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProjectGetProjectDetailsForGridJsonResponse", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", IsWrapped=true)]
    public partial class ProjectGetProjectDetailsForGridJsonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=0)]
        public string ProjectGetProjectDetailsForGridJsonResult;
        
        public ProjectGetProjectDetailsForGridJsonResponse() {
        }
        
        public ProjectGetProjectDetailsForGridJsonResponse(string ProjectGetProjectDetailsForGridJsonResult) {
            this.ProjectGetProjectDetailsForGridJsonResult = ProjectGetProjectDetailsForGridJsonResult;
        }
    }
}