using System.Collections.Generic;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Model;
using FluentPro.Common.Mapper.Types;

namespace FluentPro.Common.Mapper.Configurations.PropertyNameConverters
{
    public class NopPropertyNameConverter : IPropsMatcher
    {
        public Dictionary<string, string> GetPropertisMap(IEnumerable<MappingObjectPropInfo> src, IEnumerable<MappingObjectPropInfo> dest)
        {
            var result = new Dictionary<string, string>();
            foreach (var srcProp in src)
            {
                result.Add(srcProp.Name, srcProp.Name);
            }

            return result;
        }

        public static bool CanMap(MappingPair mappingPair)
        {
            if (mappingPair.Src.CanContainWhitespacesInProperties && mappingPair.Dest.CanContainWhitespacesInProperties)
            {
                return true;
            }

            if (!mappingPair.Src.CanContainWhitespacesInProperties && !mappingPair.Dest.CanContainWhitespacesInProperties)
            {
                return true;
            }

            return false;
        }
    }
}
