using FluentPro.FluentPS.Common.Mapper.Model;
using System.Collections.Generic;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IPropertiesResolver { }

    public interface IPropertiesResolver<in TSource, in TDestination> : IPropertiesResolver
    {
        IEnumerable<PropInfo> GetProperties(TSource source, TDestination dest);
    }
}
