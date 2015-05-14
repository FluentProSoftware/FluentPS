using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System.Collections.Generic;

namespace FluentPro.FluentPS.Common.Mapper.Configurations.MappingObjects
{
    public abstract class BaseMappingObject : IMappingObject
    {
        public Dictionary<string, object> ExternalData { get; set; }

        public virtual object UnderlyingObject { get; set; }
    }
}
