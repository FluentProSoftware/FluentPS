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

namespace FluentPro.FluentPS.Common.Mapper
{
    public static class DsMapper
    {
        private static readonly Dictionary<Type, IPropertiesResolver> PropertiesResolvers = new Dictionary<Type, IPropertiesResolver>
        {
           {typeof(DataTableReader), new DataTableReaderPropertiesResolver()},
           {typeof(object), new PocoPropertiesResolver() }
        };

        private static readonly IObjectResolver ObjectResolver = new DefaultObjectResolver();

        private static readonly INamingConvention NamingConvention = new DefaultNamingConvention();

        public static TDest Map<TSource, TDest>(TSource src)
        {
            var dest = ObjectResolver.CreateInstance<TDest>();

            var destPropsResolver = GetPropsResolver<TDest>();
            var destProps = destPropsResolver.GetProperties(dest);

            var srcPropsResolver = GetPropsResolver<TSource>();
            var srcProps = srcPropsResolver.GetProperties(src).ToArray();

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
                    var srcVal = srcPropsResolver.GetPropertyValue(src, propInfo);
                    destPropsResolver.SetPropertyValue(dest, prop, srcVal);
                }
            }

            return dest;
        }

        private static IPropertiesResolver<T> GetPropsResolver<T>()
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
