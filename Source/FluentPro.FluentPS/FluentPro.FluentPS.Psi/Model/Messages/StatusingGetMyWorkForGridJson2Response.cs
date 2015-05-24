namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="StatusingGetMyWorkForGridJson2Response", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", IsWrapped=true)]
    public partial class StatusingGetMyWorkForGridJson2Response {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=0)]
        public string StatusingGetMyWorkForGridJson2Result;
        
        public StatusingGetMyWorkForGridJson2Response() {
        }
        
        public StatusingGetMyWorkForGridJson2Response(string StatusingGetMyWorkForGridJson2Result) {
            this.StatusingGetMyWorkForGridJson2Result = StatusingGetMyWorkForGridJson2Result;
        }
    }
}