using System.Collections.Generic;
using FluentPro.Common.Mapper.Interfaces;

namespace FluentPro.Common.Mapper.Configurations.MappingObjects
{
    public abstract class BaseMappingObject : IMappingObject
    {
        public Dictionary<string, object> ExternalData { get; set; }

        public virtual object UnderlyingObject { get; set; }

        public virtual bool CanDiscoverProperties { get; private set; }

        public virtual bool CanContainWhitespacesInProperties { get; private set; }
    }
}
