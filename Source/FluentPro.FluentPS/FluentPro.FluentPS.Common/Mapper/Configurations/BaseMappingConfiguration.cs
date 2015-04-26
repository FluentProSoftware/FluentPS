using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.MappingStrategies;
using FluentPro.FluentPS.Common.Mapper.Resolvers.MappingObjects;
using FluentPro.FluentPS.Common.Mapper.Resolvers.ObjectResolvers;
using FluentPro.FluentPS.Common.Types;

namespace FluentPro.FluentPS.Common.Mapper.Configurations
{
    public abstract class BaseMappingConfiguration : IMappingConfiguration
    {
        public BaseMappingConfiguration()
        {
            ObjectResolver = new ActivatorObjectResolver();

            MappingObjects = new FuncToTypeDictionary<object>
            {
                { MappingObjectsList.IsValid, typeof(MappingObjectsList) },                
                { DataRowMappingObject.IsValid, typeof(DataRowMappingObject) },                          
                { DictionaryMappingObject.IsValid, typeof(DictionaryMappingObject) },
                { DataTableReaderMappingObject.IsValid, typeof(DataTableReaderMappingObject) },
                { PocoMappingObject.IsValid, typeof(PocoMappingObject) }                
            };

            MappingStrategies = new FuncToTypeDictionary<MappingPair>
            {
                { ForEachDestPropFindPropInSrcMappingStrategy.CanMap, typeof(ForEachDestPropFindPropInSrcMappingStrategy) },
                { ForEachSrcPropFindPropInDestMappingStrategy.CanMap, typeof(ForEachSrcPropFindPropInDestMappingStrategy) }
                                
                // new ForEachSrcPropFindPropInDestForGenericListMappingStrategy(),
                // new ForEachSrcPropAddOrSetPropInDestMappingStrategyWithSameName(),

                // new ForEachSrcPropFindPropInDestMappingStrategy(),
                // new ForEachDestPropFindPropInSrcMappingStrategy()
            };
        }

        public IObjectResolver ObjectResolver { get; set; }

        public IPropertyNameConverter PropertyNameConverter { get; set; }

        public FuncToTypeDictionary<object> MappingObjects { get; set; }

        public FuncToTypeDictionary<MappingPair> MappingStrategies { get; set; }

    }
}
