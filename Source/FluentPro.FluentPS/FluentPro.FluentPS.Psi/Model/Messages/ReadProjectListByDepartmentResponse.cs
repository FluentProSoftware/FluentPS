﻿using System.Diagnostics;
using System.ServiceModel;
using FluentPro.FluentPS.Psi.Model.DataSets;

namespace FluentPro.FluentPS.Psi.Model.Messages
{
    [DebuggerStepThrough]
    [MessageContract(WrapperName = "ReadProjectListByDepartmentResponse", WrapperNamespace = "http://schemas.microsoft.com/office/project/server/webservices/Project/", IsWrapped = true)]
    public partial class ReadProjectListByDepartmentResponse
    {
        [MessageBodyMember(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/Project/", Order = 0)]
        public ProjectDataSet ReadProjectListByDepartmentResult;

        public ReadProjectListByDepartmentResponse()
        {
        }

        public ReadProjectListByDepartmentResponse(ProjectDataSet ReadProjectListByDepartmentResult)
        {
            this.ReadProjectListByDepartmentResult = ReadProjectListByDepartmentResult;
        }
    }
}
