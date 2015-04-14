using FluentPro.FluentPS.Common.Extensions;
using FluentPro.FluentPS.Common.Mapper.Exceptions;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.MappingStrategies;
using FluentPro.FluentPS.Common.Mapper.Resolvers.MappingDestinations;
using FluentPro.FluentPS.Common.Mapper.Resolvers.MappingSources;
using FluentPro.FluentPS.Common.Mapper.Resolvers.ObjectResolvers;
using FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesAccessors;
using FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesResolvers;
using FluentPro.FluentPS.Common.Types;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace FluentPro.FluentPS.Common.Mapper.Configurations
{
    public abstract class BaseMappingConfiguration : IMappingConfiguration
    {
        public BaseMappingConfiguration()
        {
            ObjectResolver = new ActivatorObjectResolver();

            PropertiesResolvers = new Dictionary<Type, IPropertiesResolver>
            {
                {typeof(IDictionary), new DictionaryPropertiesResolver()},
                {typeof(DataTableReader), new DataTableReaderPropertiesResolver()},
                {typeof(object), new PocoPropertiesResolver() }
            };

            PropertiesAccessors = new Dictionary<Type, IPropertiesAccessor>
            {
                {typeof(IDictionary), new DictionaryPropertiesAccessor()},
                {typeof(DataTableReader), new DataTableReaderPropertiesAccessor() },
                {typeof(object), new PocoPropertiesAccessor() }
            };

            MappingSources = new Dictionary<Type, Func<object, IMappingSource>>
            {
                {typeof(DataTableReader), o => new DataTableReaderMappingSource(o as DataTableReader)}
            };

            MappingDestinations = new Dictionary<Type, Func<object, IMappingDestination>>
            { 
                {typeof(List<>), o => new ListMappingDestination(o)}
            };

            MappingStrategies = new List<IMappingStrategy>
            {
                new ForEachSrcPropFindPropInDestForGenericListMappingStrategy(),
                new ForEachSrcPropAddOrSetPropInDestMappingStrategyWithSameName(),
                new ForEachSrcPropFindPropInDestMappingStrategy(),
                new ForEachDestPropFindPropInSrcMappingStrategy()
            };
        }

        public IObjectResolver ObjectResolver { get; set; }

        public IPropertyNameConverter PropertyNameConverter { get; set; }

        public Dictionary<Type, IPropertiesResolver> PropertiesResolvers { get; set; }

        public Dictionary<Type, IPropertiesAccessor> PropertiesAccessors { get; set; }

        public Dictionary<Type, Func<object, IMappingSource>> MappingSources { get; set; }

        public Dictionary<Type, Func<object, IMappingDestination>> MappingDestinations { get; set; }

        public List<IMappingStrategy> MappingStrategies { get; set; }

        public virtual IMappingStrategy GetMappingStrategy<TSrc, TDest>()
        {
            foreach (var mappingStrategy in MappingStrategies)
            {
                mappingStrategy.MappingConfiguration = this;
                if (mappingStrategy.CanMap<TSrc, TDest>())
                {
                    return mappingStrategy;
                }
            }

            throw new MissingMappingStrategyException("The mapping strategy missing for supplied types")
            {
                Src = typeof(TSrc),
                Dest = typeof(TDest)
            };
        }

        public virtual IMappingSource GetMappingSource(object obj)
        {
            var type = obj.GetType();
            foreach (var mappingSource in MappingSources)
            {
                if (mappingSource.Key.IsAssignableFromType(type))
                {
                    return mappingSource.Value(obj);
                }
            }

            throw new MissingMappingStrategyException("The mapping source missing for supplied type")
            {
                Src = type
            };
        }

        public virtual IMappingDestination GetMappingDestination(object obj)
        {
            var type = obj.GetType();
            foreach (var mappingDestinations in MappingDestinations)
            {
                if (mappingDestinations.Key.IsAssignableFromType(type))
                {
                    return mappingDestinations.Value(obj);
                }
            }

            throw new MissingMappingDestinationException("The mapping destination missing for supplied type")
            {
                Dest = type
            };
        }

        public virtual IPropertiesAccessor GetPropsAccessor(Type t)
        {
            foreach (var propertiesAccessor in PropertiesAccessors)
            {
                if (propertiesAccessor.Key.IsAssignableFrom(t))
                {
                    var accessor = propertiesAccessor.Value as IPropertiesAccessor;
                    if (accessor != null)
                    {
                        return accessor;
                    }
                }
            }

            throw new MissingPropertyAccessorException("The property accessor missing for supplied type")
            {
                Type = t
            };
        }

        public virtual IPropertiesResolver GetPropsResolver(Type t)
        {
            foreach (var propertiesResolver in PropertiesResolvers)
            {
                if (propertiesResolver.Key.IsAssignableFrom(t))
                {
                    var resolver = propertiesResolver.Value as IPropertiesResolver;
                    if (resolver != null)
                    {
                        return resolver;
                    }
                }
            }

            throw new MissingPropertyResolverException("The property resolver missing for supplied type")
            {
                Type = t
            };
        }
    }
}
