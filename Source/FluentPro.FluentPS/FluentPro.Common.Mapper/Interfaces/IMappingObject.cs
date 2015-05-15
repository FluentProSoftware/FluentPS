using System.Collections.Generic;

namespace FluentPro.Common.Mapper.Interfaces
{
    public interface IMappingObject
    {
        object UnderlyingObject { get; set; }
        bool CanDiscoverProperties { get; }
        bool CanContainWhitespacesInProperties { get; }
        Dictionary<string, object> ExternalData { get; set; }
    }
}
