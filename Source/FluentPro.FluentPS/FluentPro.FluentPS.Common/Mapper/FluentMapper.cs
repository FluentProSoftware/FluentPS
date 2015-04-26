using FluentPro.FluentPS.Common.Mapper.Configurations;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Types;

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

        public static FluentMapper PsMapper
        {
            get { return FluentMapperContainer.PsMapper; }
        }

        public static FluentMapper PlainMapper
        {
            get { return FluentMapperContainer.PlainMapper; }
        }
        
        public TDest Map<TSrc, TDest>(TSrc src)
        {
            var dest = mapperConfiguration.ObjectResolver.CreateInstance<TDest>();
            Map(src, dest);
            return dest;
        }

        public void Map<TSrc, TDest>(TSrc src, TDest dest)
        {
            var srcMappingObjectType = mapperConfiguration.MappingObjects.Get(src);
            var srcMappingObject = mapperConfiguration.ObjectResolver.CreateInstance(srcMappingObjectType) as IMappingObject;
            srcMappingObject.UnderlyingObject = src;

            var destMappingObjectType = mapperConfiguration.MappingObjects.Get(dest);
            var destMappingObject = mapperConfiguration.ObjectResolver.CreateInstance(destMappingObjectType) as IMappingObject;
            destMappingObject.UnderlyingObject = dest;
            
            var mappingPair = new MappingPair(srcMappingObject, destMappingObject);

            var strategyType = mapperConfiguration.MappingStrategies.Get(mappingPair);
            var strategy = mapperConfiguration.ObjectResolver.CreateInstance(strategyType) as IMappingStrategy;
            strategy.Map(mappingPair, mapperConfiguration);
        }

        private class FluentMapperContainer
        {
            static FluentMapperContainer() { }

            internal static readonly FluentMapper PsMapper = new FluentMapper(new PsMappingConfiguration());

            internal static readonly FluentMapper PlainMapper = new FluentMapper(new PlainMappingConfiguration());
        }
    }
}
