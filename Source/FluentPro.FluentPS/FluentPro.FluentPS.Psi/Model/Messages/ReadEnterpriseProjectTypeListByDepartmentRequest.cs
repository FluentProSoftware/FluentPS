namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadEnterpriseProjectTypeListByDepartment", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/Workflow/", IsWrapped=true)]
    public partial class ReadEnterpriseProjectTypeListByDepartmentRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/Workflow/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.Guid> departmentUid;
        
        public ReadEnterpriseProjectTypeListByDepartmentRequest()
        {
        }
        
        public ReadEnterpriseProjectTypeListByDepartmentRequest(System.Nullable<System.Guid> departmentUid)
        {
            this.departmentUid = departmentUid;
        }
    }
}