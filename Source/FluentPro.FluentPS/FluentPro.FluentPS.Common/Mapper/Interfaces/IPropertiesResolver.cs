using FluentPro.FluentPS.Common.Mapper.Model;
using System.Collections.Generic;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IPropertiesResolver
    {
    }

    public interface IPropertiesResolver<in T> : IPropertiesResolver
    {
        IEnumerable<PropInfo> GetProperties(T target);
        object GetPropertyValue(T target, PropInfo prop);
        void SetPropertyValue(T target, PropInfo prop, object value);
    }
}
