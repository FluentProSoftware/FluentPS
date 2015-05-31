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
        /// Creates a new object in the list of objects, moves pointer to this new object.
        /// </summary>
        /// <returns></returns>
        void New();

        /// <summary>
        /// Returns current object from list of objects.
        /// </summary>
        object Current { get; }
    }
}
