using AURScheduler.DBContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AURScheduler.Core.DbContext
{
    public interface IUnitOfWork : IDisposable
    {
        AURDbContext Context { get; }
        Task<List<T>> ExecuteStoredProc<T>(string storedProcName, Dictionary<string, object> procParams) where T : class;
    }
}
