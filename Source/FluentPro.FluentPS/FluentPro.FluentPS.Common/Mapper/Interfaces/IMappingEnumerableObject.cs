namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IMappingEnumerableObject : IMappingObject
    {
        void Add(IMappingSingleObject obj);
        bool Next();
        IMappingSingleObject Current { get; }
    }
}
