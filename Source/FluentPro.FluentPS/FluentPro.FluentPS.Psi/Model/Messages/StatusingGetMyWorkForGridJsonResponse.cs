namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="StatusingGetMyWorkForGridJsonResponse", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", IsWrapped=true)]
    public partial class StatusingGetMyWorkForGridJsonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=0)]
        public string StatusingGetMyWorkForGridJsonResult;
        
        public StatusingGetMyWorkForGridJsonResponse() {
        }
        
        public StatusingGetMyWorkForGridJsonResponse(string StatusingGetMyWorkForGridJsonResult) {
            this.StatusingGetMyWorkForGridJsonResult = StatusingGetMyWorkForGridJsonResult;
        }
    }
}