using Microsoft.EntityFrameworkCore;

namespace Repositories.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext context { get; }

        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }
        public void Commit()
        {
            this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
