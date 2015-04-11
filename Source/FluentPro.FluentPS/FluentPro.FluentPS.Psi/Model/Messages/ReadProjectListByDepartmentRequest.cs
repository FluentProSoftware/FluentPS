using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [DebuggerStepThrough]
    [MessageContract(WrapperName = "ReadProjectListByDepartment", WrapperNamespace = "http://schemas.microsoft.com/office/project/server/webservices/Project/", IsWrapped = true)]
    public partial class ReadProjectListByDepartmentRequest
    {
        [MessageBodyMember(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/Project/", Order = 0)]
        [XmlElement(IsNullable = true)]
        public Nullable<Guid> departmentUid;

        public ReadProjectListByDepartmentRequest()
        {
        }

        public ReadProjectListByDepartmentRequest(Nullable<Guid> departmentUid)
        {
            this.departmentUid = departmentUid;
        }
    }
}
