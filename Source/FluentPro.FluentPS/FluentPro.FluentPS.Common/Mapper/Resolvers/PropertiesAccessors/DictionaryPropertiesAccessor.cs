using System.Collections;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesAccessors
{
    public class DictionaryPropertiesAccessor : IPropertiesAccessor<IDictionary>
    {
        public object GetPropertyValue(IDictionary target, PropInfo prop)
        {
            return target[prop.Name];
        }

        public void SetPropertyValue(IDictionary target, PropInfo prop, object value)
        {
            target[prop.Name] = value;
        }
    }
}
