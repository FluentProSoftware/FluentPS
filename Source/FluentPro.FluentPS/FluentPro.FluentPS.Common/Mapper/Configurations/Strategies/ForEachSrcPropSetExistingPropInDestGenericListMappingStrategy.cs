using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Types;

namespace FluentPro.FluentPS.Common.Mapper.Strategies
{
    public class ForEachSrcPropSetExistingPropInDestGenericListMappingStrategy : IMappingStrategy
    {
        public IPropertyNameConverter PropertyNameConverter { get; set; }

        public IMappingConfiguration MapperConfiguration { get; set; }

        public void Map(MappingPair mappingPair)
        {
            var src = mappingPair.Src as IMappingEnumerableObject;
            var dest = mappingPair.Dest as IMappingEnumerableObject;

            while (src.Next())
            {
                var genericType = dest.UnderlyingObject.GetType().GetGenericArguments()[0];
                var instance = MapperConfiguration.ObjectResolver.CreateInstance(genericType);

                var currentDestMappingObjectType = MapperConfiguration.MappingObjects.Get(instance);
                var currentDest = MapperConfiguration.ObjectResolver.CreateInstance(currentDestMappingObjectType) as IMappingSingleObject;
                currentDest.UnderlyingObject = instance;

                var currentSrcMappingObjectType = MapperConfiguration.MappingObjects.Get(src.Current);
                var currentSrc = MapperConfiguration.ObjectResolver.CreateInstance(currentSrcMappingObjectType) as IMappingSingleObject;
                currentSrc.UnderlyingObject = src.Current;

                var pair = new MappingPair(currentSrc, currentDest);
                var strategyType = MapperConfiguration.MappingStrategies.Get(pair);
                var strategy = MapperConfiguration.ObjectResolver.CreateInstance(strategyType) as IMappingStrategy;
                strategy.MapperConfiguration = MapperConfiguration;
                strategy.PropertyNameConverter = PropertyNameConverter;
                strategy.Map(pair);

                dest.Add(currentDest.UnderlyingObject);
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

        //public void Map<TSrc, TDest>(TSrc src, TDest dest)
        //{
        //    var srcPropsAccessor = MappingConfiguration.GetPropsAccessor(typeof(TSrc));
        //    var srcProps = MappingConfiguration.GetPropsResolver(typeof(TSrc)).GetProperties(src).ToArray();

        //    while (srcWrapped.Next())
        //    {
        //        var obj = MappingConfiguration.ObjectResolver.CreateInstance(destUnderlyingObjectType);
        //        foreach (var prop in srcProps)
        //        {
        //            var convertedName = MappingConfiguration.PropertyNameConverter.GetName(prop.Name);
        //            var propInfo = destProps.FirstOrDefault(p => p.Name == convertedName);
        //            if (propInfo != null)
        //            {
        //                var srcVal = srcPropsAccessor.GetPropertyValue(srcWrapped.Current, prop.Name);
        //                destPropsAccessor.SetPropertyValue(obj, convertedName, srcVal);
        //            }
        //        }

        //        typeof(TDest)
        //            .GetMethod("Add")
        //            .Invoke(dest, new object[] { obj });
        //    }
        //}

    }
}
