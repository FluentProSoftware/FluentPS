namespace FluentPro.Common.Mapper.Interfaces
{
    /// <summary>
    /// Provides sequential access to a list of objects for mapping.
    /// </summary>
    public interface IMappingEnumerableObject : IMappingObject
    {
        /// <summary>
        /// Moves pointer to next object.
        /// </summary>
        /// <returns></returns>
        bool Next();

        /// <summary>
        /// Creates a new object in the list of objects and returns it, moves pointer to this new object.
        /// </summary>
        /// <returns></returns>
        object New();

        /// <summary>
        /// Returns current object from list of objects.
        /// </summary>
        object Current { get; }
    }
}
