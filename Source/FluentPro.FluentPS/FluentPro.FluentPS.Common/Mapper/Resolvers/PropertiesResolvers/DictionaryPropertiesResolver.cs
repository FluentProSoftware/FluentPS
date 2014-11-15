using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
using System.Collections.Generic;
using System.Linq;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesResolvers
{
    public class DictionaryPropertiesResolver : IPropertiesResolver<Dictionary<string, object>>
    {
        public IEnumerable<PropInfo> GetProperties(Dictionary<string, object> target)
        {
            return target.Keys.Select(key => new PropInfo
            {
                Name = key,
                Type = target[key].GetType()
            });
        }
    }
}
