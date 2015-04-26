using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System.Text;

namespace FluentPro.FluentPS.Common.Mapper.Converters.PropertyNameConverters
{
    /// <summary>
    /// Convert upper case underscore property names to camel case property names.
    /// E.g. map PSI like column names (PROJ_UID) to normal C# names like ProjUid
    /// It should also handle cases when users types in custom field name. 
    /// </summary>
    public class UpperUnderscoreToCamelCasePropertyNameConverter : IPropertyNameConverter
    {
        public string GetDestName(string sourceName)
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

        public string GetSourceName(string sourceName)
        {
            var sb = new StringBuilder();
            sb.Append(sourceName[0]);
            for (var i = 1; i < sourceName.Length; i++)
            {
                var x = sourceName[i];
                if (char.IsUpper(x))
                {
                    sb.Append('_');
                }

                sb.Append(x);
            }

            return sb.ToString().ToUpper();
        }
    }
}
