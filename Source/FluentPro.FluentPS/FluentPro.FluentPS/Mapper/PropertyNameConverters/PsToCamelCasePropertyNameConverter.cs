using System.Data;
using System.Linq;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Types;
using FluentPro.FluentPS.Constants;

namespace FluentPro.FluentPS.Mapper.PropertyNameConverters
{
    public class PsToCamelCasePropertyNameConverter : IPropertyNameConverter
    {
        private static readonly string[] SupportedTables = {
            PsDataTableNames.Project,
            PsDataTableNames.Task,
            PsDataTableNames.Assignment,
            PsDataTableNames.Resources,
            PsDataTableNames.ProjectTeam
        };

        public string GetName(string sourceName)
        {
            var field = PsNativeFields.AllFields.FirstOrDefault(f => f.PsiName == sourceName);
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
                if (SupportedTables.Contains(dataTable.TableName))
                {
                    return true;
                }
                
                return false;
            }

            var dataRow = mappingPair.Src.UnderlyingObject as DataRow;
            if (dataRow != null)
            {
                if (SupportedTables.Contains(dataRow.Table.TableName))
                {
                    return true;
                }
                
                return false;
            }

            return false;
        }

    }
}
