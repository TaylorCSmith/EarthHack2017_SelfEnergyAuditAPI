using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnergyAudit.Data
{
    public interface IDataClient
    {
        IEnumerable<T> Query<T>();
        Task<Guid> Insert<T>(T document);
        Task CreateDatabase(string name = "EnergyAudit");
        Task CreateCollection<T>();
    }
}
