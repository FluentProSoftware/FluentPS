using System;
using FluentPro.FluentPS.Model;

namespace FluentPro.FluentPS.Psi.Tests.Integration.ProjectMapping.Model
{
    public class BasicProjectCustomField
    {
        public Guid MdPropUid { get; set; }

        public string MdPropName { get; set; }

        //// TODO: Add support for GUID -> EntityType conversion
        public Guid MdEntTypeUid { get; set; }

        public PsDataType MdPropTypeEnum { get; set; }
    }
}
