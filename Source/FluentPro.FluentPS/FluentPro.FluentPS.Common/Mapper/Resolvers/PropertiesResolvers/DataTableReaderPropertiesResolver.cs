using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesResolvers
{
    public class DataTableReaderPropertiesResolver : IPropertiesResolver<DataTableReader>
    {
        public IEnumerable<PropInfo> GetProperties(DataTableReader target)
        {
            return target.GetSchemaTable().Columns.Cast<DataColumn>().Select(c => new PropInfo
            {
                Name = c.ColumnName,
                Type = c.DataType
            });
        }

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
