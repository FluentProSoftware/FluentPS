using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadOrCreateWebObjectsResponse", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/ObjectLinkProvider" +
                                                                                                                 "/", IsWrapped=true)]
    public partial class ReadOrCreateWebObjectsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/ObjectLinkProvider" +
                                                                  "/", Order=0)]
        public ObjectLinkProviderDataSet lookupDataSet;
        
        public ReadOrCreateWebObjectsResponse()
        {
        }
        
        public ReadOrCreateWebObjectsResponse(ObjectLinkProviderDataSet lookupDataSet)
        {
            this.lookupDataSet = lookupDataSet;
        }
    }
}