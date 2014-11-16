using FluentPro.FluentPS.Common.Mapper.Exceptions;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Types;
using System;
using System.Collections.Generic;

namespace FluentPro.FluentPS.Common.Mapper.Model
{
    /// <summary>
    /// The context class. Contains all the objects used during mapping. Acts as a service locator.
    /// </summary>
    public class MapperContext
    {
        public MapperContext(IPropertyNameConverter propertyNameConverter,
            IObjectResolver objectResolver,
            Dictionary<Type, IPropertiesAccessor> propertiesAccessors,
            Dictionary<Type, IPropertiesResolver> propertiesResolvers,
            Dictionary<Pair<Type, Type>, IMappingStrategy> mappingStrategies)
        {
            MappingStrategies = mappingStrategies;
            PropertiesResolvers = propertiesResolvers;
            PropertiesAccessors = propertiesAccessors;
            ObjectResolver = objectResolver;
            PropertyNameConverter = propertyNameConverter;
        }

        public Dictionary<Type, IPropertiesResolver> PropertiesResolvers { get; private set; }

        public Dictionary<Type, IPropertiesAccessor> PropertiesAccessors { get; private set; }

        public Dictionary<Pair<Type, Type>, IMappingStrategy> MappingStrategies { get; private set; }

        public IObjectResolver ObjectResolver { get; private set; }

        public IPropertyNameConverter PropertyNameConverter { get; private set; }

        public IMappingStrategy GetMappingStrategy<TSrc, TDest>()
        {
            foreach (var mappingStrategy in MappingStrategies)
            {
                if (mappingStrategy.Key.First.IsAssignableFrom(typeof(TSrc)) && mappingStrategy.Key.Second.IsAssignableFrom(typeof(TDest)))
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

        public IPropertiesAccessor GetPropsAccessor<T>()
        {
            foreach (var propertiesAccessor in PropertiesAccessors)
            {
                if (propertiesAccessor.Key.IsAssignableFrom(typeof(T)))
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
                Type = typeof(T)
            };
        }

        public IPropertiesResolver<T> GetPropsResolver<T>()
        {
            foreach (var propertiesResolver in PropertiesResolvers)
            {
                if (propertiesResolver.Key.IsAssignableFrom(typeof(T)))
                {
                    var resolver = propertiesResolver.Value as IPropertiesResolver<T>;
                    if (resolver != null)
                    {
                        return resolver;
                    }
                }
            }

            throw new MissingPropertyResolverException("The property resolver missing for supplied type")
            {
                Type = typeof(T)
            };
        }
    }
}
