using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
using System.Collections.Generic;
using System.Linq;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesResolvers
{
    public class DictionaryPropertiesResolver : IPropertiesResolver
    {
        public IEnumerable<PropInfo> GetProperties(object target)
        {
            var dict = target as Dictionary<string, object>;
            return dict.Keys.Select(key => new PropInfo
            {
                Name = key,
                Type = dict[key].GetType()
            });
        }
    }
}
