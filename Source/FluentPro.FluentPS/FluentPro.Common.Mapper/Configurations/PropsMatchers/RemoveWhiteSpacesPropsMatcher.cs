using System.Collections.Generic;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Model;
using FluentPro.Common.Mapper.Types;

namespace FluentPro.Common.Mapper.Configurations.PropsMatchers
{
    public class RemoveWhiteSpacesPropsMatcher : IPropNamesMatcher
    {
        public Dictionary<string, string> GetPropertiesMap(IEnumerable<MappingObjectPropInfo> src, IEnumerable<MappingObjectPropInfo> dest)
        {
            var result = new Dictionary<string, string>();
            foreach (var srcProp in src)
            {
                result.Add(srcProp.Name, srcProp.Name.Replace(" ", ""));
            }

            return result;
        }

        public static bool CanMap(MappingPair mappingPair)
        {
            if (!mappingPair.Dest.CanContainWhitespacesInProperties)
            {
                return true;
            }

            return false;
        }
    }
}
