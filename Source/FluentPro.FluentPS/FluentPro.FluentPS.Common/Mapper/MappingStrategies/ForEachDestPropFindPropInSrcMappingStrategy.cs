using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Common.Mapper.Model;

namespace FluentPro.FluentPS.Common.Mapper.MappingStrategies
{
    public class ForEachDestPropFindPropInSrcMappingStrategy : IMappingStrategy
    {
        public void Map<TSrc, TDest>(MapperContext ctx, TSrc src, TDest dest)
        {
            throw new NotImplementedException();
        }
    }
}
