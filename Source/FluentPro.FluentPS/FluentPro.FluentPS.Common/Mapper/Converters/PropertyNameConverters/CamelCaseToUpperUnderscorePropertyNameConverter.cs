using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System.Text;

namespace FluentPro.FluentPS.Common.Mapper.Converters.PropertyNameConverters
{
    public class CamelCaseToUpperUnderscorePropertyNameConverter : IPropertyNameConverter
    {
        public string GetName(string sourceName)
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
