using FluentPro.FluentPS.Common.Mapper.Exceptions;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System;
using System.Collections.Generic;

namespace FluentPro.FluentPS.Common.Mapper.Model
{
    public class MapperContext
    {
        public MapperContext(IPropertyNameConverter propertyNameConverter,
            IObjectResolver objectResolver,
            Dictionary<Type, IPropertiesAccessor> propertiesAccessors,
            Dictionary<Type, IPropertiesResolver> propertiesResolvers)
        {
            PropertiesResolvers = propertiesResolvers;
            PropertiesAccessors = propertiesAccessors;
            ObjectResolver = objectResolver;
            PropertyNameConverter = propertyNameConverter;
        }

        public Dictionary<Type, IPropertiesResolver> PropertiesResolvers { get; private set; }

        public Dictionary<Type, IPropertiesAccessor> PropertiesAccessors { get; private set; }

        public IObjectResolver ObjectResolver { get; private set; }

        public IPropertyNameConverter PropertyNameConverter { get; private set; }

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
