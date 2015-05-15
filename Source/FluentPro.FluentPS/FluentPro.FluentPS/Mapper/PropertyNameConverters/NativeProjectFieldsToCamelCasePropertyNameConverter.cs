using System;
using System.Data;
using System.Text;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Types;
using FluentPro.FluentPS.Constants;

namespace FluentPro.FluentPS.Mapper.PropertyNameConverters
{
    public class NativeProjectFieldsToCamelCasePropertyNameConverter : IPropertyNameConverter
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
            var dataTable = mappingPair.Src.UnderlyingObject as DataTable;
            if (dataTable == null)
            {
                return false;
            }

            if (dataTable.TableName == PsDataTableNames.Project || dataTable.TableName == PsDataTableNames.ProjectCustomFields)
            {
                return true;
            }

            return false;
        }

    }
}
