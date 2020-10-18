using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Infra.Data
{
    public class InstagramCloneContext : DbContext
    {
        public InstagramCloneContext(DbContextOptions<InstagramCloneContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DefaultConnection");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}