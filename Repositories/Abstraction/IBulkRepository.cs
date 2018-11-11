using System.Collections.Generic;

namespace Repositories.Abstraction
{
    public interface IBulkRepository<TEntity, in TKey> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

    }
}
