using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using FluentPro.FluentPS.Common.Mapper.Conventions.Naming;
using FluentPro.FluentPS.Common.Mapper.Exceptions;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
using FluentPro.FluentPS.Common.Mapper.Resolvers;
using FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesResolvers;
using System.Data;
using System.Collections;
using FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesAccessors;

namespace FluentPro.FluentPS.Common.Mapper
{
    public static class DsMapper
    {
        private static readonly Dictionary<Type, IPropertiesResolver> PropertiesResolvers = new Dictionary<Type, IPropertiesResolver>
        {
            {typeof(IDictionary), new DictionaryPropertiesResolver()},
            {typeof(DataTableReader), new DataTableReaderPropertiesResolver()},
            {typeof(object), new PocoPropertiesResolver() }
        };

        private static readonly Dictionary<Type, IPropertiesAccessor> PropertiesAccessors = new Dictionary<Type, IPropertiesAccessor>
        {
            {typeof(IDictionary), new DictionaryPropertiesAccessor()},
            {typeof(DataTableReader), new DataTableReaderPropertiesAccessor() },
            {typeof(object), new PocoPropertiesAccessor() }
        };

        private static readonly IObjectResolver ObjectResolver = new DefaultObjectResolver();

        private static readonly INamingConvention NamingConvention = new DefaultNamingConvention();

        public static TDest Map<TSrc, TDest>(TSrc src)
        {
            var dest = ObjectResolver.CreateInstance<TDest>();

            var destPropsResolver = GetPropsResolver<TDest, TSrc>();
            var destPropsAccessor = GetPropsAccessor<TDest>();
            var destProps = destPropsResolver.GetProperties(dest, src);

            var srcPropsResolver = GetPropsResolver<TSrc, TDest>();
            var srcPropsAccessor = GetPropsAccessor<TSrc>();
            var srcProps = srcPropsResolver.GetProperties(src, dest).ToArray();

            foreach (var prop in destProps)
            {
                PropInfo propInfo = null;
                var srcPropertyNames = NamingConvention.GetNames(prop.Name);
                foreach (var suggestedPropertyName in srcPropertyNames)
                {
                    var srcProp = srcProps.FirstOrDefault(p => p.Name == suggestedPropertyName);
                    if (srcProp != null)
                    {
                        propInfo = srcProp;
                    }
                }

                if (propInfo != null)
                {
                    var srcVal = srcPropsAccessor.GetPropertyValue(src, propInfo);
                    destPropsAccessor.SetPropertyValue(dest, prop, srcVal);
                }
            }

            return dest;
        }

        private static IPropertiesAccessor<T> GetPropsAccessor<T>()
        {
            foreach (var propertiesAccessor in PropertiesAccessors)
            {
                if (propertiesAccessor.Key.IsAssignableFrom(typeof(T)))
                {
                    var accessor = propertiesAccessor.Value as IPropertiesAccessor<T>;
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

        private static IPropertiesResolver<TSrc, TDest> GetPropsResolver<TSrc, TDest>()
        {
            foreach (var propertiesResolver in PropertiesResolvers)
            {
                if (propertiesResolver.Key.IsAssignableFrom(typeof(TSrc)))
                {
                    var resolver = propertiesResolver.Value as IPropertiesResolver<TSrc, TDest>;
                    if (resolver != null)
                    {
                        return resolver;
                    }
                }
            }

            throw new MissingPropertyResolverException("The property resolver missing for supplied type")
            {
                Type = typeof(TSrc)
            };
        }
    }
}
