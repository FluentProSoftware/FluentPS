using System.Collections.Generic;
using System.Data;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesResolvers
{
    public class DataTableReaderPropertiesResolver : IPropertiesResolver<DataTableReader, object>
    {
        public IEnumerable<PropInfo> GetProperties(DataTableReader source, object dest)
        {
            for (var i = 0; i < source.FieldCount; i++)
            {
                yield return new PropInfo
                {
                    Name = source.GetName(i),
                    Type = source.GetFieldType(i)
                };
            }
        }
    }
}
