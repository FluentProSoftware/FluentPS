using System;
using System.Data;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesAccessors
{
    public class DataTableReaderPropertiesAccessor : IPropertiesAccessor<DataTableReader>
    {
        public object GetPropertyValue(DataTableReader target, PropInfo prop)
        {
            return target[prop.Name];
        }

        public void SetPropertyValue(DataTableReader target, PropInfo prop, object value)
        {
            throw new NotSupportedException();
        }
    }
}
