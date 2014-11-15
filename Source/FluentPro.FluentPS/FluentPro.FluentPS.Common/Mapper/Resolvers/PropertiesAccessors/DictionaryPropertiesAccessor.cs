using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System.Collections.Generic;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesAccessors
{
    public class DictionaryPropertiesAccessor : IPropertiesAccessor
    {
        public object GetPropertyValue(object target, string propName)
        {
            var dict = (Dictionary<string, object>)target;
            return dict[propName];
        }

        public void SetPropertyValue(object target, string propName, object value)
        {
            var dict = (Dictionary<string, object>)target;
            dict[propName] = value;
        }
    }
}
