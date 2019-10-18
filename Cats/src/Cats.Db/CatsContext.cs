using Cats.Model;
using Microsoft.EntityFrameworkCore;

namespace Cats.Db
{
    public class CatsContext : DbContext
    {
        public virtual DbSet<Cat> Cats { get; set; } = null!;

        public CatsContext(DbContextOptions<CatsContext> options)
               : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ModelBuilder_Cats.BuildModel(modelBuilder);
        }
    }
}
