using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesResolvers
{
    public class PocoPropertiesResolver : IPropertiesResolver<object>
    {
        public IEnumerable<PropInfo> GetProperties(object target)
        {
            return target.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).Select(p => new PropInfo
            {
                Name = p.Name,
                Type = p.PropertyType
            });
        }

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
