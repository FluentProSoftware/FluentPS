using FluentPro.FluentPS.Common.Types;
using System;
using System.Collections.Generic;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IMappingConfiguration
    {
        IObjectResolver ObjectResolver { get; }

        IPropertyNameConverter PropertyNameConverter { get; }

        Dictionary<Type, IPropertiesResolver> PropertiesResolvers { get; }

        Dictionary<Type, IPropertiesAccessor> PropertiesAccessors { get; }

        Dictionary<Type, Func<object, IMappingSource>> MappingSources { get; }

        Dictionary<Type, Func<object, IMappingDestination>> MappingDestinations { get; }

        Dictionary<Pair<Type, Type>, IMappingStrategy> MappingStrategies { get; }

        IMappingStrategy GetMappingStrategy<TSrc, TDest>();

        IMappingSource GetMappingSource(object obj);

        IMappingDestination GetMappingDestination(object obj);

        IPropertiesAccessor GetPropsAccessor(Type t);

        IPropertiesResolver GetPropsResolver(Type t);
    }
}
