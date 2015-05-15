using System;

namespace FluentPro.Common.Mapper.Tests.Model
{
    public class EntityWithPlainNames
    {
        public Guid PropertyGuid { get; set; }

        public Guid PropGuid { get; set; }

        public string PropertyString { get; set; }

        public int PropertyInt { get; set; }

        public string PropertyWithSpace { get; set; }

        public DummyEnum PropertyWithDummyEnum { get; set; }

        public DummyEnum PropertyWithDummyEnum1 { get; set; }
    }
}
