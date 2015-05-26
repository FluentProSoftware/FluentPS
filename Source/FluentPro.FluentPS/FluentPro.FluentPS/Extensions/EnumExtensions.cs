namespace FluentPro.FluentPS.Extensions
{
    using System;

    public static class EnumExtensions
    {
        public static T GetAttr<T>(this Enum enm) where T : Attribute
        {
            var type = enm.GetType();
            var memInfo = type.GetMember(enm.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
            return (attributes.Length > 0) ? (T)attributes[0] : null;
        }

        public static TEnum GetByAttr<TEnum, TAttr>(Func<TAttr, bool> func)
            where TAttr : Attribute
            where TEnum : IConvertible
        {
            var names = Enum.GetNames(typeof(TEnum));
            foreach(var name in names)
            {
                var enumMember = (Enum)Enum.Parse(typeof (TEnum), name, true);
                var attr = enumMember.GetAttr<TAttr>();
                if (attr == null)
                {
                    continue;
                }

                if (func(attr))
                {
                    return (TEnum)((IConvertible) enumMember);
                }
            }

            return default(TEnum);
        }
    }
}
