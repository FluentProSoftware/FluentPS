using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadEnterpriseProjectTypeListByDepartmentResponse", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/Workflow/", IsWrapped=true)]
    public partial class ReadEnterpriseProjectTypeListByDepartmentResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/Workflow/", Order=0)]
        public WorkflowDataSet ReadEnterpriseProjectTypeListByDepartmentResult;
        
        public ReadEnterpriseProjectTypeListByDepartmentResponse()
        {
        }
        
        public ReadEnterpriseProjectTypeListByDepartmentResponse(WorkflowDataSet ReadEnterpriseProjectTypeListByDepartmentResult)
        {
            this.ReadEnterpriseProjectTypeListByDepartmentResult = ReadEnterpriseProjectTypeListByDepartmentResult;
        }
    }
}