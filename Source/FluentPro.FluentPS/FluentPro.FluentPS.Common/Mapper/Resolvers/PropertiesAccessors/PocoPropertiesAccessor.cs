using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesAccessors
{
    public class PocoPropertiesAccessor : IPropertiesAccessor<object>
    {
        public object GetPropertyValue(object target, PropInfo prop)
        {
            return target.GetType().GetProperty(prop.Name).GetValue(target, null);
        }

        public void SetPropertyValue(object target, PropInfo prop, object value)
        {
            target.GetType().GetProperty(prop.Name).SetValue(target, value, null);
        }
    }
}
