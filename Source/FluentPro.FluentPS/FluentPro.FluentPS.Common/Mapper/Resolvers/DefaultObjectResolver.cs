using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers
{
    public class DefaultObjectResolver : IObjectResolver
    {
        public T CreateInstance<T>()
        {
            return Activator.CreateInstance<T>();
        }
    }
}
