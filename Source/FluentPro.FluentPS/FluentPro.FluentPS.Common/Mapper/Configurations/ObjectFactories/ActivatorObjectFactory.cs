using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System;

namespace FluentPro.FluentPS.Common.Mapper.Configurations.ObjectFactories
{
    public class ActivatorObjectFactory : IMappingObjectFactory
    {
        public object CreateInstance(Type type)
        {
            return Activator.CreateInstance(type);
        }
    }
}
