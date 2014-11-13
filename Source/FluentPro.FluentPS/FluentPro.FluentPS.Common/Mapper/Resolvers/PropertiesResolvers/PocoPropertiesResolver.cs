using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesResolvers
{
    public class PocoPropertiesResolver : IPropertiesResolver<object, object>
    {
        public IEnumerable<PropInfo> GetProperties(object source, object dest)
        {
            return source.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).Select(p => new PropInfo
            {
                Name = p.Name,
                Type = p.PropertyType
            });
        }
    }
}
