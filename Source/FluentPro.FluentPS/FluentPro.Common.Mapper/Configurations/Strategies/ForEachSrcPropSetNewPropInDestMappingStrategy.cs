using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Types;

namespace FluentPro.Common.Mapper.Configurations.Strategies
{
    /// <summary>
    /// Find all properties in source and set them to target. It is used when mapping to an empty dictionary.
    /// </summary>
    public class ForEachSrcPropSetNewPropInDestMappingStrategy : IMappingStrategy
    {
        public IPropertyNameConverter PropertyNameConverter { get; set; }

        public IMappingConfiguration MapperConfiguration { get; set; }

        public void Map(MappingPair mappingPair)
        {
            var src = mappingPair.Src as IMappingSingleObject;
            var dest = mappingPair.Dest as IMappingSingleObject;

            var srcProps = src.Properties;

            foreach (var prop in srcProps)
            {
                var srcVal = src[prop.Name];
                var convertedName = PropertyNameConverter.GetName(prop.Name);
                dest[convertedName] = srcVal;
            }
        }

        public static bool CanMap(MappingPair mappingPair)
        {
            var src = mappingPair.Src as IMappingSingleObject;
            var dest = mappingPair.Dest as IMappingSingleObject;

            return src.CanDiscoverProperties && !dest.CanDiscoverProperties;
        }
    }
}
