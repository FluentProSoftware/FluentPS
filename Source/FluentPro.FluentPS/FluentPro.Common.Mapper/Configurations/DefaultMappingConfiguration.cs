﻿using FluentPro.Common.Mapper.Configurations.MappingObjects;
using FluentPro.Common.Mapper.Configurations.ObjectFactories;
using FluentPro.Common.Mapper.Configurations.PropsMatchers;
using FluentPro.Common.Mapper.Configurations.Strategies;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Types;

namespace FluentPro.Common.Mapper.Configurations
{
    public class DefaultMappingConfiguration : IMappingConfiguration
    {
        public DefaultMappingConfiguration()
        {
            ObjectFactory = new ActivatorObjectFactory();

            MappingObjects = new FuncToTypeList<object>
            {
                new FuncToTypeListItem<object>(MappingObjectsList.IsValid, typeof(MappingObjectsList)),   
                new FuncToTypeListItem<object>(DataRowMappingObject.IsValid, typeof(DataRowMappingObject)),                          
                new FuncToTypeListItem<object>(DictionaryMappingObject.IsValid, typeof(DictionaryMappingObject)),
                new FuncToTypeListItem<object>(DataTableReaderMappingObject.IsValid, typeof(DataTableReaderMappingObject)),
                new FuncToTypeListItem<object>(PocoMappingObject.IsValid, typeof(PocoMappingObject))       
            };

            MappingStrategies = new FuncToTypeList<MappingPair>
            {
                new FuncToTypeListItem<MappingPair>(ForEachSrcPropSetPropInDestEnumerablesMappingStrategy.CanMap, typeof(ForEachSrcPropSetPropInDestEnumerablesMappingStrategy)),
                new FuncToTypeListItem<MappingPair>(ForEachSrcPropSetPropInDestMappingStrategy.CanMap, typeof(ForEachSrcPropSetPropInDestMappingStrategy))
            };

            PropertyNameConverters = new FuncToTypeList<MappingPair>
            {
                new FuncToTypeListItem<MappingPair>(NopPropsMatcher.CanMap, typeof(NopPropsMatcher)),
                new FuncToTypeListItem<MappingPair>(RemoveWhiteSpacesPropsMatcher.CanMap, typeof(RemoveWhiteSpacesPropsMatcher))
            };
        }

        public IMappingObjectFactory ObjectFactory { get; set; }

        public FuncToTypeList<object> MappingObjects { get; set; }

        public FuncToTypeList<MappingPair> MappingStrategies { get; set; }

        public FuncToTypeList<MappingPair> PropertyNameConverters { get; set; }
    }
}
