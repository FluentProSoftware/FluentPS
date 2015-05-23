namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadResourceListByDepartment", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/Resource/", IsWrapped=true)]
    public partial class ReadResourceListByDepartmentRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/Resource/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.Guid> departmentUid;
        
        public ReadResourceListByDepartmentRequest()
        {
        }
        
        public ReadResourceListByDepartmentRequest(System.Nullable<System.Guid> departmentUid)
        {
            this.departmentUid = departmentUid;
        }
    }
}