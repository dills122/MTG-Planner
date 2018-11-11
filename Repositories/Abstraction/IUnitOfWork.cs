using Microsoft.EntityFrameworkCore;
using System;

namespace Repositories.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext context { get; }
        void Commit();
    }
}
