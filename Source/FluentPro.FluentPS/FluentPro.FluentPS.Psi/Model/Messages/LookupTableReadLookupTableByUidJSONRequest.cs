using FluentPro.FluentPS.Psi.Model.Enums;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LookupTableReadLookupTableByUidJSON", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", IsWrapped=true)]
    public partial class LookupTableReadLookupTableByUidJSONRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=0)]
        public System.Guid ltUid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=1)]
        public int language;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=2)]
        public string currency;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<DateFormatType> format;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.Guid> projUid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> requestId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/PWA/", Order=6)]
        public string query;
        
        public LookupTableReadLookupTableByUidJSONRequest() {
        }
        
        public LookupTableReadLookupTableByUidJSONRequest(System.Guid ltUid, int language, string currency, System.Nullable<DateFormatType> format, System.Nullable<System.Guid> projUid, System.Nullable<int> requestId, string query) {
            this.ltUid = ltUid;
            this.language = language;
            this.currency = currency;
            this.format = format;
            this.projUid = projUid;
            this.requestId = requestId;
            this.query = query;
        }
    }
}