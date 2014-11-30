using FluentPro.FluentPS.Common.Mapper.Exceptions;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Types;
using System;
using System.Collections.Generic;
using FluentPro.FluentPS.Common.Extensions;

namespace FluentPro.FluentPS.Common.Mapper.Model
{
    /// <summary>
    /// The context class. Contains all the objects used during mapping. Acts as a service locator.
    /// </summary>
    public class MapperContext
    {
        public MapperContext(IPropertyNameConverter propertyNameConverter,
            IObjectResolver objectResolver,
            Dictionary<Type, Func<object, IMappingSource>> mappingSources,
            Dictionary<Type, Func<object, IMappingDestination>> mappingDestinations,
            Dictionary<Type, IPropertiesAccessor> propertiesAccessors,
            Dictionary<Type, IPropertiesResolver> propertiesResolvers,
            Dictionary<Pair<Type, Type>, IMappingStrategy> mappingStrategies)
        {
            MappingSources = mappingSources;
            MappingDestinations = mappingDestinations;
            MappingStrategies = mappingStrategies;
            PropertiesResolvers = propertiesResolvers;
            PropertiesAccessors = propertiesAccessors;
            ObjectResolver = objectResolver;
            PropertyNameConverter = propertyNameConverter;
        }

        public Dictionary<Type, IPropertiesResolver> PropertiesResolvers { get; private set; }

        public Dictionary<Type, Func<object, IMappingSource>> MappingSources { get; private set; }

        public Dictionary<Type, Func<object, IMappingDestination>> MappingDestinations { get; private set; }

        public Dictionary<Type, IPropertiesAccessor> PropertiesAccessors { get; private set; }

        public Dictionary<Pair<Type, Type>, IMappingStrategy> MappingStrategies { get; private set; }

        public IObjectResolver ObjectResolver { get; private set; }

        public IPropertyNameConverter PropertyNameConverter { get; private set; }

        public IMappingStrategy GetMappingStrategy<TSrc, TDest>()
        {
            foreach (var mappingStrategy in MappingStrategies)
            {
                if (mappingStrategy.Key.First.IsAssignableFromType(typeof(TSrc)) && mappingStrategy.Key.Second.IsAssignableFromType(typeof(TDest)))
                {
                    return mappingStrategy.Value;
                }
            }

            throw new MissingMappingStrategyException("The mapping strategy missing for supplied types")
            {
                Src = typeof(TSrc),
                Dest = typeof(TDest)
            };
        }

        public IMappingSource GetMappingSource(object obj)
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

        public IMappingDestination GetMappingDestination(object obj)
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

        public IPropertiesAccessor GetPropsAccessor(Type t)
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

        public IPropertiesResolver GetPropsResolver(Type t)
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
