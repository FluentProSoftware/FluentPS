using System;

namespace FluentPro.FluentPS.Extensions
{
    public static class EnumExtensions
    {
        public static T GetAttr<T>(this Enum enm) where T : Attribute
        {
            var type = enm.GetType();
            var memInfo = type.GetMember(enm.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
            return (attributes.Length > 0) ? (T)attributes[0] : null;
        }
    }
}
