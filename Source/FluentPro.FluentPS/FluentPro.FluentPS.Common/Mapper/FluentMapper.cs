using FluentPro.FluentPS.Common.Mapper.Configurations;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Types;

namespace FluentPro.FluentPS.Common.Mapper
{
    /// <summary>
    /// FluentMapper provides core functionality for mapping between objects.
    /// </summary>
    public class FluentMapper
    {
        private readonly IMappingConfiguration mapperConfiguration;

        public FluentMapper(IMappingConfiguration config)
        {
            mapperConfiguration = config;
        }

        public static FluentMapper Current
        {
            get { return FluentMapperContainer.Current; }
        }

        public TDest Map<TSrc, TDest>(TSrc src, IPropertyNameConverter propertyNameConverter = null, IMappingStrategy mappingStrategy = null)
        {
            var dest = (TDest)mapperConfiguration.ObjectFactory.CreateInstance(typeof(TDest));
            Map(src, dest, propertyNameConverter, mappingStrategy);
            return dest;
        }

        public void Map<TSrc, TDest>(TSrc src, TDest dest, IPropertyNameConverter propertyNameConverter = null, IMappingStrategy mappingStrategy = null)
        {
            var srcMappingObjectType = mapperConfiguration.MappingObjects.Get(src);
            var srcMappingObject = mapperConfiguration.ObjectFactory.CreateInstance(srcMappingObjectType) as IMappingObject;
            srcMappingObject.UnderlyingObject = src;

            var destMappingObjectType = mapperConfiguration.MappingObjects.Get(dest);
            var destMappingObject = mapperConfiguration.ObjectFactory.CreateInstance(destMappingObjectType) as IMappingObject;
            destMappingObject.UnderlyingObject = dest;

            var mappingPair = new MappingPair(srcMappingObject, destMappingObject);

            var strategyType = mapperConfiguration.MappingStrategies.Get(mappingPair);
            var strategy = mappingStrategy ?? mapperConfiguration.ObjectFactory.CreateInstance(strategyType) as IMappingStrategy;
            strategy.MapperConfiguration = mapperConfiguration;
            strategy.PropertyNameConverter = propertyNameConverter ?? mapperConfiguration.ObjectFactory.CreateInstance(mapperConfiguration.PropertyNameConverters.Get(mappingPair)) as IPropertyNameConverter;
            strategy.Map(mappingPair);

            dest = (TDest)mappingPair.Dest.UnderlyingObject;
        }

        private class FluentMapperContainer
        {
            static FluentMapperContainer() { }

            internal static readonly FluentMapper Current = new FluentMapper(new DefaultMappingConfiguration());
        }
    }
}
