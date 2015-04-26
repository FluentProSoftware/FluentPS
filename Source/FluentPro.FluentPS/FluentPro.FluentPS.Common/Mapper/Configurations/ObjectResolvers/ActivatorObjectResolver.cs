using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System;

namespace FluentPro.FluentPS.Common.Mapper.ObjectResolvers
{
    public class ActivatorObjectResolver : IObjectResolver
    {
        public T CreateInstance<T>()
        {
            return Activator.CreateInstance<T>();
        }

        public object CreateInstance(Type type)
        {
            return Activator.CreateInstance(type);
        }
    }
}
