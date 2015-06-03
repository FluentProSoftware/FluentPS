using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Model;
using FluentPro.Common.Mapper.Types;

namespace FluentPro.FluentPS.Mapper.PropsMatchers
{
    public class PsToCamelCasePropsMatcher : IPropNamesMatcher
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
            var capitalizeAfter = new[] { '_', '-' };
            var capitalizeNext = false;
            var sb = new StringBuilder();
            sb.Append(sourceName[0]);
            for (var i = 1; i < sourceName.Length; i++)
            {
                while (capitalizeAfter.Contains(sourceName[i]))
                {
                    i++;
                    capitalizeNext = true;
                } 
                
                if (char.IsWhiteSpace(sourceName[i]))
                {
                    continue;
                }

                if (capitalizeNext)
                {
                    sb.Append(char.ToUpper(sourceName[i]));
                    capitalizeNext = false;
                    continue;
                }

                if (char.IsUpper(sourceName[i]) && (char.IsLower(sourceName[i - 1]) || char.IsWhiteSpace(sourceName[i - 1])))
                {
                    sb.Append(sourceName[i]);
                    continue;
                }

                sb.Append(char.ToLower(sourceName[i]));
            }

            return sb.ToString();
        }

        public static bool CanMap(MappingPair mappingPair)
        {
            var dataTable = mappingPair.Src.UnderlyingObject as DataTable;
            if (dataTable != null)
            {
                if (dataTable.Namespace.Contains("http://schemas.microsoft.com/office/project/server"))
                {
                    return true;
                }

                return false;
            }

            var dataRow = mappingPair.Src.UnderlyingObject as DataRow;
            if (dataRow != null)
            {
                if (dataRow.Table.Namespace.Contains("http://schemas.microsoft.com/office/project/server"))
                {
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}
