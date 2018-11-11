using Microsoft.EntityFrameworkCore;

namespace Repositories.ContextFactory
{
    public interface IDatabaseContextFactory
    {
        DbContext Create();
    }
}
