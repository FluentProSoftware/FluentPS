using System.Collections;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesAccessors
{
    public class DictionaryPropertiesAccessor : IPropertiesAccessor
    {
        public object GetPropertyValue(object target, PropInfo prop)
        {
            var dict = (IDictionary)target;
            return dict[prop.Name];
        }

        public void SetPropertyValue(object target, PropInfo prop, object value)
        {
            var dict = (IDictionary)target;
            dict[prop.Name] = value;
        }
    }
}
