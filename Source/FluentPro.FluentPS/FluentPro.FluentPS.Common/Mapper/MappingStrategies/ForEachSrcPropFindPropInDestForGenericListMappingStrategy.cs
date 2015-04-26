using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using FluentPro.FluentPS.Common.Extensions;
using System.Collections.Generic;

namespace FluentPro.FluentPS.Common.Mapper.MappingStrategies
{
    //public class ForEachSrcPropFindPropInDestForGenericListMappingStrategy : IMappingStrategy
    //{
    //    public IMappingConfiguration MappingConfiguration { get; set; }

    //    public bool CanMap<TSrc, TDest>()
    //    {
    //        return typeof(DataTableReader).IsAssignableFromType(typeof(TSrc)) &&
    //            typeof(List<>).IsAssignableFromType(typeof(TDest));
    //    }

    //    public void Map<TSrc, TDest>(TSrc src, TDest dest)
    //    {
    //        //var srcWrapped = MappingConfiguration.GetMappingSource(src);
    //        //var destUnderlyingObjectType = typeof(TDest).GetGenericArguments()[0];

    //        //var destPropsAccessor = MappingConfiguration.GetPropsAccessor(destUnderlyingObjectType);

    //        //var destProps = MappingConfiguration
    //        //    .GetPropsResolver(destUnderlyingObjectType)
    //        //    .GetProperties(MappingConfiguration.ObjectResolver.CreateInstance(destUnderlyingObjectType))
    //        //    .ToArray();

    //        //var srcPropsAccessor = MappingConfiguration.GetPropsAccessor(typeof(TSrc));
    //        //var srcProps = MappingConfiguration.GetPropsResolver(typeof(TSrc)).GetProperties(src).ToArray();

    //        //while (srcWrapped.Next())
    //        //{
    //        //    var obj = MappingConfiguration.ObjectResolver.CreateInstance(destUnderlyingObjectType);
    //        //    foreach (var prop in srcProps)
    //        //    {
    //        //        var convertedName = MappingConfiguration.PropertyNameConverter.GetName(prop.Name);
    //        //        var propInfo = destProps.FirstOrDefault(p => p.Name == convertedName);
    //        //        if (propInfo != null)
    //        //        {
    //        //            var srcVal = srcPropsAccessor.GetPropertyValue(srcWrapped.Current, prop.Name);
    //        //            destPropsAccessor.SetPropertyValue(obj, convertedName, srcVal);
    //        //        }
    //        //    }

    //        //    typeof(TDest)
    //        //        .GetMethod("Add")
    //        //        .Invoke(dest, new object[] { obj });
    //        //}
    //    }
    //}
}
