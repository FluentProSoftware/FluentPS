using FluentPro.FluentPS.Common.Mapper.Model;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IPropertiesAccessor { }

    public interface IPropertiesAccessor<T> : IPropertiesAccessor
    {
        object GetPropertyValue(T target, PropInfo prop);
        void SetPropertyValue(T target, PropInfo prop, object value);
    }
}
