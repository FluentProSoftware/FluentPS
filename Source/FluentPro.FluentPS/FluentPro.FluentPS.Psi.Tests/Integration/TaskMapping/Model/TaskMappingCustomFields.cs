using System;
using FluentPro.FluentPS.Model;

namespace FluentPro.FluentPS.Psi.Tests.Integration.TaskMapping.Model
{
    public class TaskMappingCustomFields
    {
        public Guid MdPropUid { get; set; }

        public string MdPropName { get; set; }

        public Guid MdEntTypeUid { get; set; }

        public PsDataType MdPropTypeEnum { get; set; }
    }
}
