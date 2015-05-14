using System.Collections.Generic;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IMappingObject
    {
        object UnderlyingObject { get; set; }

        Dictionary<string, object> ExternalData { get; set; }
    }
}
