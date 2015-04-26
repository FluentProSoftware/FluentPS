using FluentPro.FluentPS.Common.Extensions;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FluentPro.FluentPS.Common.Mapper.MappingStrategies
{
    /// <summary>
    /// Find all properties in source and set them to target. It is used when mapping datareader to Dictionary.
    /// </summary>
    //public class ForEachSrcPropAddOrSetPropInDestMappingStrategyWithSameName : IMappingStrategy
    //{
    //    public IMappingConfiguration MappingConfiguration { get; set; }

    //    public bool CanMap<TSrc, TDest>()
    //    {
    //        return typeof(DataTableReader).IsAssignableFromType(typeof(TSrc))
    //            && typeof(Dictionary<string, object>).IsAssignableFromType(typeof(TDest));
    //    }

    //    public void Map<TSrc, TDest>(TSrc src, TDest dest)
    //    {
    //        //var destPropsAccessor = MappingConfiguration.GetPropsAccessor(typeof(TDest));
    //        //var srcPropsAccessor = MappingConfiguration.GetPropsAccessor(typeof(TSrc));

    //        //var srcProps = MappingConfiguration.GetPropsResolver(typeof(TSrc))
    //        //    .GetProperties(src)
    //        //    .ToArray();

    //        //foreach (var prop in srcProps)
    //        //{
    //        //    var srcVal = srcPropsAccessor.GetPropertyValue(src, prop.Name);
    //        //    destPropsAccessor.SetPropertyValue(dest, prop.Name, srcVal);
    //        //}
    //    }
    //}
}
