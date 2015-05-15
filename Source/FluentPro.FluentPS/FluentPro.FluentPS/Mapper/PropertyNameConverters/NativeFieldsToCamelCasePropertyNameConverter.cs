using System.Data;
using System.Linq;
using System.Text;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Types;
using FluentPro.FluentPS.Constants;

namespace FluentPro.FluentPS.Mapper.PropertyNameConverters
{
    public class NativeFieldsToCamelCasePropertyNameConverter : IPropertyNameConverter
    {
        private static readonly string[] SupportedTables = {
            PsDataTableNames.Project,
            PsDataTableNames.ProjectCustomFields,
            PsDataTableNames.Task,
            PsDataTableNames.TaskCustomFields,
            PsDataTableNames.Assignment,
            PsDataTableNames.AssignmentCustomFields
        };

        public string GetName(string sourceName)
        {
            var sb = new StringBuilder();
            sb.Append(sourceName[0]);
            for (var i = 1; i < sourceName.Length; i++)
            {
                var x = sourceName[i];
                if (x == '_')
                {
                    i++;
                    sb.Append(char.ToUpper(sourceName[i]));
                    continue;
                }

                if (char.IsUpper(x) && (char.IsLower(sourceName[i - 1]) || char.IsWhiteSpace(sourceName[i - 1])))
                {
                    sb.Append(x);
                    continue;
                }

                if (char.IsWhiteSpace(x))
                {
                    continue;
                }

                sb.Append(char.ToLower(x));
            }

            return sb.ToString();
        }

        public static bool CanMap(MappingPair mappingPair)
        {
            var dataTable = mappingPair.Src.UnderlyingObject as DataTable;
            if (dataTable != null)
            {
                if (dataTable.DataSet.DataSetName != "ProjectDataSet")
                {
                    return false;
                }

                if (!SupportedTables.Contains(dataTable.TableName))
                {
                    return false;
                }

                if (!mappingPair.Dest.CanContainWhitespacesInProperties)
                {
                    return true;
                }

                return false;
            }

            var dataRow = mappingPair.Src.UnderlyingObject as DataRow;
            if (dataRow != null)
            {
                if (dataRow.Table.DataSet.DataSetName != "ProjectDataSet")
                {
                    return false;
                }

                if (!SupportedTables.Contains(dataRow.Table.TableName))
                {
                    return false;
                }

                if (!mappingPair.Dest.CanContainWhitespacesInProperties)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

    }
}
