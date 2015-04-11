using FluentPro.FluentPS.Common.Mapper.Model;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IMappingStrategy
    {
        void Map<TSrc, TDest>(IMappingConfiguration config, TSrc src, TDest dest);
    }
}
