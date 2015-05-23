namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetADSyncReplacementCharacterResponse", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/Admin/", IsWrapped=true)]
    public partial class GetADSyncReplacementCharacterResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/Admin/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<char> GetADSyncReplacementCharacterResult;
        
        public GetADSyncReplacementCharacterResponse()
        {
        }
        
        public GetADSyncReplacementCharacterResponse(System.Nullable<char> GetADSyncReplacementCharacterResult)
        {
            this.GetADSyncReplacementCharacterResult = GetADSyncReplacementCharacterResult;
        }
    }
}