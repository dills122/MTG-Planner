using BusinessObjects.StateObjects;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class StateContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Deck> Decks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Mtg-Deck-Planner;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
