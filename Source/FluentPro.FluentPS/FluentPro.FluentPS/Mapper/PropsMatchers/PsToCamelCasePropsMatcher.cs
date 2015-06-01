using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Model;
using FluentPro.Common.Mapper.Types;
using FluentPro.FluentPS.Metadata;

namespace FluentPro.FluentPS.Mapper.PropsMatchers
{
    public class PsToCamelCasePropsMatcher : IPropsMatcher
    {
        public Dictionary<string, string> GetPropertiesMap(IEnumerable<MappingObjectPropInfo> src, IEnumerable<MappingObjectPropInfo> dest)
        {
            var result = new Dictionary<string, string>();
            foreach (var srcProp in src)
            {
                var possibleName = GetPropertyName(srcProp.Name);
                var propertyCandidate = dest.FirstOrDefault(p => p.Name == possibleName);
                if (propertyCandidate == null)
                {
                    continue;
                }

                result.Add(srcProp.Name, possibleName);
            }

            return result;
        }

        private string GetPropertyName(string sourceName)
        {
            var sb = new StringBuilder();
            sb.Append(sourceName[0]);
            for (var i = 1; i < sourceName.Length; i++)
            {
                var x = sourceName[i];
                if (x == '_' || x == '-')
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
