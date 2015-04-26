using FluentPro.FluentPS.Common.Mapper.Configurations.MappingObjects;
using FluentPro.FluentPS.Common.Mapper.Configurations.ObjectFactories;
using FluentPro.FluentPS.Common.Mapper.Configurations.PropertyNameConverters;
using FluentPro.FluentPS.Common.Mapper.Configurations.Strategies;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Types;

namespace FluentPro.FluentPS.Common.Mapper.Configurations
{
    public class DefaultMappingConfiguration : IMappingConfiguration
    {
        public DefaultMappingConfiguration()
        {
            ObjectFactory = new ActivatorObjectFactory();

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
                { ForEachSrcPropSetExistingPropInDestGenericListMappingStrategy.CanMap, typeof(ForEachSrcPropSetExistingPropInDestGenericListMappingStrategy)},
                { ForEachSrcPropSetNewPropInDestMappingStrategy.CanMap, typeof(ForEachSrcPropSetNewPropInDestMappingStrategy) },
                { ForEachSrcPropSetExistingPropInDestMappingStrategy.CanMap, typeof(ForEachSrcPropSetExistingPropInDestMappingStrategy) },
                { ForEachDestPropSetExistingPropInSrcMappingStrategy.CanMap, typeof(ForEachDestPropSetExistingPropInSrcMappingStrategy) }
            };

            PropertyNameConverters = new FuncToTypeDictionary<MappingPair>
            {
                { UpperUnderscoreToCamelCasePropertyNameConverter.CanMap, typeof(UpperUnderscoreToCamelCasePropertyNameConverter) }
            };
        }

        public IMappingObjectFactory ObjectFactory { get; set; }

        public FuncToTypeDictionary<object> MappingObjects { get; set; }

        public FuncToTypeDictionary<MappingPair> MappingStrategies { get; set; }

        public FuncToTypeDictionary<MappingPair> PropertyNameConverters { get; set; }
    }
}
