using System.Linq;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Types;

namespace FluentPro.Common.Mapper.Configurations.Strategies
{
    /// <summary>
    /// For each property in source, find a property in destination and copy value from source to destination.
    /// </summary>
    public class ForEachSrcPropSetPropInDestMappingStrategy : IMappingStrategy
    {
        public IMappingConfiguration MapperConfiguration { get; set; }

        public IPropNamesMatcher PropsMatcher { get; set; }

        public IPropValueConverter PropValueConverter { get; set; }

        public void Map(MappingPair mappingPair)
        {
            var src = mappingPair.Src as IMappingSingleObject;
            var dest = mappingPair.Dest as IMappingSingleObject;
            
            var props = PropsMatcher.GetPropertiesMap(src.Properties, dest.Properties);
            foreach (var prop in props)
            {
                var propInfo = src.Properties.FirstOrDefault(p => p.Name == prop.Key);
                if (propInfo == null)
                {
                    continue;
                }

                var srcVal = PropValueConverter.GetConvertedValue(propInfo, null, src[prop.Key]);
                dest[prop.Value] = srcVal;
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

            return true;
        }
    }
}
