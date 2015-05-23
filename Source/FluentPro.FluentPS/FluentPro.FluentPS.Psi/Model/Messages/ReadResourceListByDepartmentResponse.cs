using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadResourceListByDepartmentResponse", WrapperNamespace="http://schemas.microsoft.com/office/project/server/webservices/Resource/", IsWrapped=true)]
    public partial class ReadResourceListByDepartmentResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/office/project/server/webservices/Resource/", Order=0)]
        public ResourceDataSet ReadResourceListByDepartmentResult;
        
        public ReadResourceListByDepartmentResponse()
        {
        }
        
        public ReadResourceListByDepartmentResponse(ResourceDataSet ReadResourceListByDepartmentResult)
        {
            this.ReadResourceListByDepartmentResult = ReadResourceListByDepartmentResult;
        }
    }
}