using System;

namespace FluentPro.FluentPS.Common.Extensions
{
    public static class TypeExtensions
    {
        public static bool IsAssignableFromType(this Type genericType, Type givenType)
        {
            if (genericType.IsAssignableFrom(givenType))
            {
                return true;
            }

            var interfaceTypes = givenType.GetInterfaces();
            foreach (var it in interfaceTypes)
            {
                if (it.IsGenericType && it.GetGenericTypeDefinition() == genericType)
                {
                    return true;
                }
            }

            if (givenType.IsGenericType && givenType.GetGenericTypeDefinition() == genericType)
            {
                return true;
            }

            Type baseType = givenType.BaseType;
            if (baseType == null)
            {
                return false;
            }

            return IsAssignableFromType(baseType, genericType);
        }
    }
}
