namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IMappingSource
    {
        object Current { get; }
        bool Next();
    }
}
