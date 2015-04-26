using FluentPro.FluentPS.Common.Mapper.Interfaces;

namespace FluentPro.FluentPS.Common.Mapper.Configurations.PropertyNameConverters
{
    public class LeaveOriginalNamePropertyNameConverter : IPropertyNameConverter
    {
        public string GetName(string sourceName)
        {
            return sourceName;
        }
    }
}
