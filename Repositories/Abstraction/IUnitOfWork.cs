using Microsoft.EntityFrameworkCore;
using System;

namespace Repositories.Abstraction
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext context { get; }
        void Commit();
    }
}
