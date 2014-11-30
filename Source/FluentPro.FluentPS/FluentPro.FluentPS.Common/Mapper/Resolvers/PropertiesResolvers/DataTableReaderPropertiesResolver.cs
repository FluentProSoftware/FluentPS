using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
using System.Collections.Generic;
using System.Data;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesResolvers
{
    public class DataTableReaderPropertiesResolver : IPropertiesResolver
    {
        public IEnumerable<PropInfo> GetProperties(object target)
        {
            var reader = target as DataTableReader;
            for (var i = 0; i < reader.FieldCount; i++)
            {
                yield return new PropInfo
                {
                    Name = reader.GetName(i),
                    Type = reader.GetFieldType(i)
                };
            }
        }
    }
}
