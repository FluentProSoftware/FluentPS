﻿using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Types;
using System.Linq;

namespace FluentPro.FluentPS.Common.Mapper.MappingStrategies
{
    /// <summary>
    /// For each property in source, find a property in destination and copy value from source to destination. 
    /// If there is no such property in destination - do nothing.
    /// </summary>
    public class ForEachSrcPropFindPropInDestMappingStrategy : IMappingStrategy
    {
        public void Map(MappingPair mappingPair, IMappingConfiguration config)
        {
            var src = mappingPair.Src as IMappingSingleObject;
            var dest = mappingPair.Dest as IMappingSingleObject;

            var destProps = dest.Properties;
            var srcProps = src.Properties;

            foreach (var prop in srcProps)
            {
                var convertedName = config.PropertyNameConverter.GetDestName(prop.Name);
                var propInfo = destProps.FirstOrDefault(p => p.Name == convertedName);
                if (propInfo != null)
                {
                    var srcVal = src[prop.Name];
                    dest[convertedName] = srcVal;
                }
            }
        }

        public static bool CanMap(MappingPair mappingObjects)
        {
            var src = mappingObjects.Src as IMappingSingleObject;
            var dest = mappingObjects.Dest as IMappingSingleObject;

            return src.CanDiscoverProperties;
        }
    }
}
