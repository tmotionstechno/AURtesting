using AURScheduler.Core.Domains;
using LinqToDB.Data;

namespace AURScheduler.Core.DbContext
{
    /// <summary>
    /// Represents an entity repository
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public partial interface IRepository<TEntity> where TEntity : BaseEntity
    {
        #region Methods

        /// <summary>
        /// Executes command using System.Data.CommandType.StoredProcedure command type
        /// and returns results as collection of values of specified type
        /// </summary>
        /// <param name="storeProcedureName">Store procedure name</param>
        /// <param name="dataParameters">Command parameters</param>
        /// <returns>Collection of query result records</returns>
        Task<IList<TEntity>> EntityFromSql(string storeProcedureName, params DataParameter[] dataParameters);
        #endregion
    }
}
