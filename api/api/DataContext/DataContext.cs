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
        public DbSet<FileImage> FileImages { get; set; }

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

            modelBuilder.Entity<FileImage>()
                .HasOne(x => x.Lot)
                .WithMany(x => x.FileImages)
                .HasForeignKey(x => x.LotId);

            modelBuilder.Entity<FileImage>().ToTable(nameof(FileImages));


            base.OnModelCreating(modelBuilder);
        }


    }
}
