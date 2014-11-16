using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System.Text;

namespace FluentPro.FluentPS.Common.Mapper.Converters.PropertyNameConverters
{
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

                sb.Append(char.ToLower(x));
            }

            return sb.ToString();
        }
    }
}
