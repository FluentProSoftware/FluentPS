using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesResolvers
{
    public class DataTableReaderPropertiesResolver : IPropertiesResolver<DataTableReader>
    {
        public IEnumerable<PropInfo> GetProperties(DataTableReader target)
        {
            for (var i = 0; i < target.FieldCount; i++)
            {
                yield return new PropInfo
                {
                    Name = target.GetName(i),
                    Type = target.GetFieldType(i)
                };
            }
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
