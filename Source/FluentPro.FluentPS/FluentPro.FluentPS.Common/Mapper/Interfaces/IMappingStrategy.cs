using FluentPro.FluentPS.Common.Mapper.Model;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IMappingStrategy
    {
        void Map<TSrc, TDest>(MapperContext ctx, TSrc src, TDest dest);
    }
}
