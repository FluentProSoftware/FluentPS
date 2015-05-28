using System;
using FluentPro.FluentPS.Model;

namespace FluentPro.FluentPS.Psi.Tests.Integration.BasicProjectMapping.Model
{
    public class BasicProjectCustomField
    {
        public Guid MdPropUid { get; set; }

        public string MdPropName { get; set; }

        //// TODO: Add support for GUID -> EntityType conversion
        public Guid MdEntTypeUid { get; set; }

        public PsConversionType MdPropTypeEnum { get; set; }
    }
}
