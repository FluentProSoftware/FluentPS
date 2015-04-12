using FluentPro.FluentPS.Common.Mapper.Model;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IMappingStrategy
    {
        IMappingConfiguration MappingConfiguration { get; set; }
        bool CanMap<TSrc, TDest>();
        void Map<TSrc, TDest>(TSrc src, TDest dest);
    }
}
