using System.Collections.Generic;
using System.Linq;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Model;
using FluentPro.Common.Mapper.Types;

namespace FluentPro.FluentPS.Mapper.PropsMatchers
{
    public class CamelCaseToPsPropsMatcher : IPropNamesMatcher
    {
        public Dictionary<string, string> GetPropertiesMap(IEnumerable<MappingObjectPropInfo> src, IEnumerable<MappingObjectPropInfo> dest)
        {
            var psConverter = new PsToCamelCasePropsMatcher();
            var map = psConverter.GetPropertiesMap(dest, src);

            return map.ToDictionary(i => i.Value, i => i.Key);
        }

        public static bool CanMap(MappingPair mappingPair)
        {
            return PsToCamelCasePropsMatcher.CanMap(new MappingPair(mappingPair.Dest, mappingPair.Src));
        }
    }
}
