using System;
using FluentPro.FluentPS.Common.Mapper.Interfaces;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.ObjectResolvers
{
    public class ActivatorObjectResolver : IObjectResolver
    {
        public T CreateInstance<T>()
        {
            return Activator.CreateInstance<T>();
        }
    }
}
