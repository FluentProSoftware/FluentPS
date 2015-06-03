using System;
using System.Collections.Generic;
using FluentPro.Common.Mapper.Configurations.PropertyValueConverters;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Types;

namespace FluentPro.Common.Mapper
{
    /// <summary>
    /// FluentMapper provides core functionality for mapping between objects.
    /// </summary>
    public class FluentMapper : IFluentMapper
    {
        private readonly IMappingConfiguration _mapperConfiguration;

        public FluentMapper(IMappingConfiguration mapperConfiguration)
        {
            _mapperConfiguration = mapperConfiguration;
        }

        public TDest Map<TSrc, TDest>(TSrc src,
            IPropNamesMatcher propsMatcher = null,
            IPropValueConverter propertyValueConverter = null,
            IMappingStrategy mappingStrategy = null,
            Dictionary<string, object> externalData = null)
        {
            var dest = (TDest)_mapperConfiguration.ObjectFactory.CreateInstance(typeof(TDest));
            Map(src, dest, propsMatcher, propertyValueConverter, mappingStrategy, externalData);
            return dest;
        }

        public void Map<TSrc, TDest>(TSrc src, TDest dest,
            IPropNamesMatcher propsMatcher = null,
            IPropValueConverter propertyValueConverter = null,
            IMappingStrategy mappingStrategy = null,
            Dictionary<string, object> externalData = null)
        {
            if (src == null)
            {
                throw new ArgumentNullException("src", "Source can not be null, specify valid source for mapping");
            }

            propertyValueConverter = propertyValueConverter ?? new NopPropertyValueConverter();
            externalData = externalData ?? new Dictionary<string, object>();

            var srcMappingObjectType = _mapperConfiguration.MappingObjects.Get(src);
            var srcMappingObject = _mapperConfiguration.ObjectFactory.CreateInstance(srcMappingObjectType) as IMappingObject;
            srcMappingObject.UnderlyingObject = src;
            srcMappingObject.ExternalData = externalData;

            var destMappingObjectType = _mapperConfiguration.MappingObjects.Get(dest);
            var destMappingObject = _mapperConfiguration.ObjectFactory.CreateInstance(destMappingObjectType) as IMappingObject;
            destMappingObject.UnderlyingObject = dest;
            destMappingObject.ExternalData = externalData;

            var mappingPair = new MappingPair(srcMappingObject, destMappingObject);

            var strategyType = _mapperConfiguration.MappingStrategies.Get(mappingPair);
            var strategy = mappingStrategy ?? _mapperConfiguration.ObjectFactory.CreateInstance(strategyType) as IMappingStrategy;
            strategy.MapperConfiguration = _mapperConfiguration;
            strategy.PropValueConverter = propertyValueConverter;
            strategy.PropsMatcher = propsMatcher ?? _mapperConfiguration.ObjectFactory.CreateInstance(_mapperConfiguration.PropertyNameConverters.Get(mappingPair)) as IPropNamesMatcher;
            strategy.Map(mappingPair);
        }
    }
}
