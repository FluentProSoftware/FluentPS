using System.Linq;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Types;

namespace FluentPro.Common.Mapper.Configurations.Strategies
{
    public class ForEachDestPropSetExistingPropInSrcMappingStrategy : IMappingStrategy
    {
        public IMappingConfiguration MapperConfiguration { get; set; }

        public IPropertyNameConverter PropertyNameConverter { get; set; }

        public void Map(MappingPair mappingPair)
        {
            var src = mappingPair.Src as IMappingSingleObject;
            var dest = mappingPair.Dest as IMappingSingleObject;

            var destProps = dest.Properties;
            var srcProps = src.Properties;
            foreach (var prop in destProps)
            {
                var convertedName = PropertyNameConverter.GetName(prop.Name);
                var propInfo = srcProps.FirstOrDefault(p => p.Name == convertedName);
                if (propInfo != null)
                {
                    var val = src[propInfo.Name];
                    dest[prop.Name] = val;
                }
            }
        }

        public static bool CanMap(MappingPair mappingObjects)
        {
            var src = mappingObjects.Src as IMappingSingleObject;
            if (src == null)
            {
                return false;
            }

            var dest = mappingObjects.Dest as IMappingSingleObject;
            if (dest == null)
            {
                return false;
            }

            return dest.CanDiscoverProperties && src.CanDiscoverProperties;
        }
    }
}
