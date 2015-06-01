using System.Data;
using System.Linq;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Types;
using FluentPro.FluentPS.Metadata;

namespace FluentPro.FluentPS.Mapper.PropertyNameConverters
{
    public class PsToCamelCasePropertyNameConverter : IPropertyNameConverter
    {
        public string GetName(string sourceName)
        {
            var field = PsMetadata.Fields.FirstOrDefault(f => f.PsName == sourceName);
            if (field == null)
            {
                return sourceName;
            }

            return field.PropertyName;
        }

        public static bool CanMap(MappingPair mappingPair)
        {
            var dataTable = mappingPair.Src.UnderlyingObject as DataTable;
            if (dataTable != null)
            {
                if (PsMetadata.Tables.Contains(dataTable.TableName))
                {
                    return true;
                }
                
                return false;
            }

            var dataRow = mappingPair.Src.UnderlyingObject as DataRow;
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
