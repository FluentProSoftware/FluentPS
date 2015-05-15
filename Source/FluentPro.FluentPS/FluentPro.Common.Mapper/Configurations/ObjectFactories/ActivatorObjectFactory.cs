using System;
using FluentPro.Common.Mapper.Interfaces;

namespace FluentPro.Common.Mapper.Configurations.ObjectFactories
{
    public class ActivatorObjectFactory : IMappingObjectFactory
    {
        public object CreateInstance(Type type)
        {
            return Activator.CreateInstance(type);
        }
    }
}
