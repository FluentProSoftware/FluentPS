namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    //TODO: Implement names cache in each property name converter to reduce memory consumption, do it after 
    // performance tests implemented.
    public interface IPropertyNameConverter
    {
        string GetDestName(string sourceName);
        string GetSourceName(string destName);
    }
}
