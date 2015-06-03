using System.Collections.Generic;

namespace FluentPro.Common.Mapper.Interfaces
{
    public interface IFluentMapper
    {
        TDest Map<TSrc, TDest>(TSrc src,
            IPropNamesMatcher propsMatcher = null,
            IPropValueConverter propertyValueConverter = null,
            IMappingStrategy mappingStrategy = null,
            Dictionary<string, object> externalData = null);

        void Map<TSrc, TDest>(TSrc src, TDest dest,
            IPropNamesMatcher propsMatcher = null,
            IPropValueConverter propertyValueConverter = null,
            IMappingStrategy mappingStrategy = null,
            Dictionary<string, object> externalData = null);
    }
}
