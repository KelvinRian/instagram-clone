using InstagramClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Infra.Data
{
    public class InstagramCloneContext : DbContext
    {
        public InstagramCloneContext(DbContextOptions<InstagramCloneContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}