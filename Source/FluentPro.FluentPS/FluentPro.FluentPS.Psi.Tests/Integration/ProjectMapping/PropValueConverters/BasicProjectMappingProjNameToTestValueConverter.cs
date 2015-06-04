using FluentPro.Common.Mapper.Interfaces;
using FluentPro.Common.Mapper.Model;

namespace FluentPro.FluentPS.Psi.Tests.Integration.ProjectMapping.PropValueConverters
{
    public class BasicProjectMappingProjNameToTestValueConverter : IPropValueConverter
    {
        public object GetConvertedValue(MappingObjectPropInfo sourcePropInfo, MappingObjectPropInfo destPropInfo, object value)
        {
            if (sourcePropInfo.Name == "PROJ_NAME")
            {
                return "Test";
            }

            return value;
        }
    }
}
