﻿using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Types;

namespace FluentPro.Common.Mapper.Configurations.Strategies
{
    /// <summary>
    /// Find all properties in source and set them to target. It is used when mapping to an empty dictionary.
    /// </summary>
    public class ForEachSrcPropSetNewPropInDestMappingStrategy : IMappingStrategy
    {
        public IMappingConfiguration MapperConfiguration { get; set; }

        public IPropsMatcher PropsMatcher { get; set; }

        public IPropertyValueConverter PropertyValueConverter { get; set; }

        public void Map(MappingPair mappingPair)
        {
            var src = mappingPair.Src as IMappingSingleObject;
            var dest = mappingPair.Dest as IMappingSingleObject;

            var srcProps = src.Properties;
            var destProps = dest.Properties;

            var props = PropsMatcher.GetPropertisMap(srcProps, destProps);
            foreach (var prop in srcProps)
            {
                var convertedName = props[prop.Name];
                var srcVal = PropertyValueConverter.GetValue(prop, src[prop.Name]);
                dest[convertedName] = srcVal;
            }
        }

        public static bool CanMap(MappingPair mappingPair)
        {
            var src = mappingPair.Src as IMappingSingleObject;
            if (src == null)
            {
                return false;
            }

            var dest = mappingPair.Dest as IMappingSingleObject;
            if (dest == null)
            {
                return false;
            }

            return src.CanDiscoverProperties && !dest.CanDiscoverProperties;
        }
    }
}
