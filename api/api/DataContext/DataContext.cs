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
        public DbSet<Lot> Lots { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable(nameof(Users));

            modelBuilder.Entity<Lot>()
                .HasOne(x => x.UserCreated)
                .WithMany(x => x.LotsCreated)
                .HasForeignKey(x => x.UserCreatedId)
                .IsRequired();
            modelBuilder.Entity<Lot>()
                .HasOne(x => x.UserBought)
                .WithMany(x => x.LotsBought)
                .HasForeignKey(x => x.UserBoughtId);
            modelBuilder.Entity<Lot>().ToTable(nameof(Lots));

            base.OnModelCreating(modelBuilder);
        }


    }
}
