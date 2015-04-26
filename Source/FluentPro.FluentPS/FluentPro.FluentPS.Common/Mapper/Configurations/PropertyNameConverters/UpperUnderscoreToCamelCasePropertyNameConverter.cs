using FluentPro.FluentPS.Common.Constants;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Types;
using System.Data;
using System.Text;

namespace FluentPro.FluentPS.Common.Mapper.Configurations.PropertyNameConverters
{
    /// <summary>
    /// Convert upper case underscore property names to camel case property names.
    /// E.g. map PSI like column names (PROJ_UID) to normal C# names like ProjUid
    /// It should also handle cases when users types in custom field name. 
    /// </summary>
    public class UpperUnderscoreToCamelCasePropertyNameConverter : IPropertyNameConverter
    {
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
            var src = mappingPair.Src as IMappingSingleObject;
            var dest = mappingPair.Dest as IMappingSingleObject;

            var dataTable = src.UnderlyingObject as DataTable;
            if (dataTable == null)
            {
                return false;
            }

            if (dataTable.TableName == PsDataTableNames.Project)
            {
                return true;
            }

            return false;
        }
    }
}
