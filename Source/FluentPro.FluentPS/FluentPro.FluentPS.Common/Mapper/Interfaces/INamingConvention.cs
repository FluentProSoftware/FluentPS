
using System.Collections.Generic;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface INamingConvention
    {
        IEnumerable<string> GetNames(string sourceName);
    }
}
