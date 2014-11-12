using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
using FluentPro.FluentPS.Common.Types;
using System.Collections.Generic;
using System.Linq;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesResolvers
{
    public class PropertyBagPropertiesResolver : IPropertiesResolver<PropertyBag>
    {
        public IEnumerable<PropInfo> GetProperties(PropertyBag target)
        {
            return target.Select(p => new PropInfo
            {
                Name = p.Key,
                Type = p.Value.GetType()
            });
        }

        public object GetPropertyValue(PropertyBag target, PropInfo prop)
        {
            return target[prop.Name];
        }

        public void SetPropertyValue(PropertyBag target, PropInfo prop, object value)
        {
            target[prop.Name] = value;
        }
    }
}
