using System;
using System.Data;
using FluentPro.FluentPS.Common.Mapper.Interfaces;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesAccessors
{
    public class DataTableReaderPropertiesAccessor : IPropertiesAccessor
    {
        public object GetPropertyValue(object target, string propName)
        {
            var reader = (DataTableReader)target;
            return reader[propName];
        }

        public void SetPropertyValue(object target, string propName, object value)
        {
            throw new NotSupportedException();
        }
    }
}
