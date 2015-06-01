using System.Linq;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Types;

namespace FluentPro.Common.Mapper.Configurations.Strategies
{
    /// <summary>
    /// For each property in source, find a property in destination and copy value from source to destination. 
    /// If there is no such property in destination - do nothing.
    /// </summary>
    public class ForEachSrcPropSetExistingPropInDestMappingStrategy : IMappingStrategy
    {
        public IMappingConfiguration MapperConfiguration { get; set; }

        public IPropsMatcher PropsMatcher { get; set; }

        public IPropertyValueConverter PropertyValueConverter { get; set; }

        public void Map(MappingPair mappingPair)
        {
            var src = mappingPair.Src as IMappingSingleObject;
            var dest = mappingPair.Dest as IMappingSingleObject;

            var destProps = dest.Properties;
            var srcProps = src.Properties;

            var props = PropsMatcher.GetPropertiesMap(srcProps, destProps);
            foreach (var prop in srcProps)
            {
                if (!props.ContainsKey(prop.Name))
                {
                    continue;
                }

                var convertedName = props[prop.Name];
                var propInfo = destProps.FirstOrDefault(p => p.Name == convertedName);
                if (propInfo != null)
                {
                    var srcVal = PropertyValueConverter.GetValue(propInfo, src[prop.Name]);
                    dest[convertedName] = srcVal;
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
