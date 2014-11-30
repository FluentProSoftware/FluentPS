namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IMappingDestination
    {
        void Add(object obj);
        object GetUnwrapedObject();
    }
}
