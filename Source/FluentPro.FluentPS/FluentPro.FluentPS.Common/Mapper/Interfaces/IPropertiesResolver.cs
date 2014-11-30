using FluentPro.FluentPS.Common.Mapper.Model;
using System.Collections.Generic;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IPropertiesResolver
    {
        IEnumerable<PropInfo> GetProperties(object traget);
    }
}
