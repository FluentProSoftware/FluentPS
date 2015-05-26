using System.Data;
using System.Linq;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Types;
using FluentPro.FluentPS.Constants;

namespace FluentPro.FluentPS.Mapper.PropertyNameConverters
{
    public class CamelCaseToPsPropertyNameConverter : IPropertyNameConverter
    {
        private static readonly string[] SupportedTables = {
            PsDataTableNames.Project,
            PsDataTableNames.Task,
            PsDataTableNames.Assignment,
            PsDataTableNames.Resources
        };

        public string GetName(string sourceName)
        {
            var field = PsNativeFields.ProjectFields.FirstOrDefault(f => f.PropertyName == sourceName);
            if (field == null)
            {
                return sourceName;
            }

            return field.PsiName;
        }

        public static bool CanMap(MappingPair mappingPair)
        {
            var dataTable = mappingPair.Dest.UnderlyingObject as DataTable;
            if (dataTable != null)
            {
                if (dataTable.DataSet.DataSetName != "ProjectDataSet")
                {
                    return false;
                }

                if (SupportedTables.Contains(dataTable.TableName))
                {
                    return true;
                }

                return false;
            }

            var dataRow = mappingPair.Dest.UnderlyingObject as DataRow;
            if (dataRow != null)
            {
                if (dataRow.Table.DataSet.DataSetName != "ProjectDataSet")
                {
                    return false;
                }

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
