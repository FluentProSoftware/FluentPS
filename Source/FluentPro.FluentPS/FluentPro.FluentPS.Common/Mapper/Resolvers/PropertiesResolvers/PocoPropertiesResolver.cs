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
    }
}
