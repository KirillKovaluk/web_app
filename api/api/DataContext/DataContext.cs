using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.DataContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable(nameof(Users));

            base.OnModelCreating(modelBuilder);
        }

    }
}
