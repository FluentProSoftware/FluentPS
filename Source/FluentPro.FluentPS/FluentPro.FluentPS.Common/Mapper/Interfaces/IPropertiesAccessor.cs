using FluentPro.FluentPS.Common.Mapper.Model;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IPropertiesAccessor
    {
        object GetPropertyValue(object target, string propName);
        void SetPropertyValue(object target, string propName, object value);
    }
}
