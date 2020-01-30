namespace Music_Library
{
    internal interface IOperation
    {
        /// <summary>
        /// Get objects form the database.
        /// </summary>
        /// <param name="id">ID of objects in the database</param>
        /// <returns>object from the database</returns>
        object Get(int id);

        /// <summary>
        /// Add objects to the database.
        /// </summary>
        /// <param name="o">Objects that need to be written to the database</param>
        /// <returns>Number of objects written to the database</returns>
        int Add(object o);

        /// <summary>
        /// Delete objects to the database.
        /// </summary>
        /// <param name="o">Objects that need to be deleted from the database</param>
        /// <returns>Number of objects deleted from the database</returns>
        int Delete(object o);

        /// <summary>
        /// Update objects in the database.
        /// </summary>
        /// <param name="o">Objects that need to be updated in the database</param>
        /// <returns>Number of objects updated in the database</returns>
        int Update(object o);
    }
}