using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Types;

namespace FluentPro.Common.Mapper.Configurations.Strategies
{
    public class ForEachSrcPropSetExistingPropInDestEnumerablesMappingStrategy : IMappingStrategy
    {
        public IPropertyNameConverter PropertyNameConverter { get; set; }

        public IMappingConfiguration MapperConfiguration { get; set; }

        public void Map(MappingPair mappingPair)
        {
            var src = mappingPair.Src as IMappingEnumerableObject;
            var dest = mappingPair.Dest as IMappingEnumerableObject;

            while (src.Next())
            {
                var currentDestMappingObjectType = MapperConfiguration.MappingObjects.Get(dest.New());
                var currentDest = MapperConfiguration.ObjectFactory.CreateInstance(currentDestMappingObjectType) as IMappingSingleObject;
                currentDest.UnderlyingObject = dest.Current;

                var currentSrcMappingObjectType = MapperConfiguration.MappingObjects.Get(src.Current);
                var currentSrc = MapperConfiguration.ObjectFactory.CreateInstance(currentSrcMappingObjectType) as IMappingSingleObject;
                currentSrc.UnderlyingObject = src.Current;

                var pair = new MappingPair(currentSrc, currentDest);
                var strategyType = MapperConfiguration.MappingStrategies.Get(pair);
                var strategy = MapperConfiguration.ObjectFactory.CreateInstance(strategyType) as IMappingStrategy;
                strategy.MapperConfiguration = MapperConfiguration;
                strategy.PropertyNameConverter = PropertyNameConverter;
                strategy.Map(pair);
            }
        }

        public static bool CanMap(MappingPair mappingPair)
        {
            var src = mappingPair.Src as IMappingEnumerableObject;
            if (src == null)
            {
                return false;
            }

            var dest = mappingPair.Dest as IMappingEnumerableObject;
            if (dest == null)
            {
                return false;
            }

            return true;
        }
    }
}
