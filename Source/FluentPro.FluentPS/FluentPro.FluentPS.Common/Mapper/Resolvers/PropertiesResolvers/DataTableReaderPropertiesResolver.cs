using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;
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
    }
}
