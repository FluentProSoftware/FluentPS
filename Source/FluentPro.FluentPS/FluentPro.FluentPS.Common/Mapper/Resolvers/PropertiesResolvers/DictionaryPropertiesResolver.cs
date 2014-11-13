using System.Collections;
using System.Collections.Generic;
using System.Data;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesResolvers
{
    public class DictionaryPropertiesResolver : IPropertiesResolver<IDictionary, DataTableReader>
    {
        public IEnumerable<PropInfo> GetProperties(IDictionary source, DataTableReader dest)
        {
            for (var i = 0; i < dest.FieldCount; i++)
            {
                yield return new PropInfo
                {
                    Name = dest.GetName(i),
                    Type = dest.GetFieldType(i)
                };
            }
        }
    }
}
