using FluentPro.FluentPS.Common.Mapper.Interfaces;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesAccessors
{
    public class PocoPropertiesAccessor : IPropertiesAccessor
    {
        public object GetPropertyValue(object target, string propName)
        {
            return target.GetType().GetProperty(propName).GetValue(target, null);
        }

        public void SetPropertyValue(object target, string propName, object value)
        {
            target.GetType().GetProperty(propName).SetValue(target, value, null);
        }
    }
}
