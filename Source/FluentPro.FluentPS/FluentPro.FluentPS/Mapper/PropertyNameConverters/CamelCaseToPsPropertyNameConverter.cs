using System.Collections.Generic;
using System.Data;
using System.Linq;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Model;
using FluentPro.Common.Mapper.Types;
using FluentPro.FluentPS.Metadata;

namespace FluentPro.FluentPS.Mapper.PropertyNameConverters
{
    public class CamelCaseToPsPropertyNameConverter : IPropsMatcher
    {
        public Dictionary<string, string> GetPropertisMap(IEnumerable<MappingObjectPropInfo> src, IEnumerable<MappingObjectPropInfo> dest)
        {
            var psConverter = new PsToCamelCasePropertyNameConverter();
            var map = psConverter.GetPropertisMap(dest, src);

            return map.ToDictionary(i => i.Value, i => i.Key);
        }

        public static bool CanMap(MappingPair mappingPair)
        {
            var dataTable = mappingPair.Dest.UnderlyingObject as DataTable;
            if (dataTable != null)
            {
                if (PsMetadata.Tables.Contains(dataTable.TableName))
                {
                    return true;
                }

                return false;
            }

            var dataRow = mappingPair.Dest.UnderlyingObject as DataRow;
            if (dataRow != null)
            {
                if (PsMetadata.Tables.Contains(dataRow.Table.TableName))
                {
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}
