using Microsoft.EntityFrameworkCore;

namespace Repositories.ContextFactory
{
    public class DatabaseContextFactory : IDatabaseContextFactory
    {
        public DatabaseContextFactory()
        {

        }

        public DbContext Create()
        {
            return new StateContext();
        }
    }
}
