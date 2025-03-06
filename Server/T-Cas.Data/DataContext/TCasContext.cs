using Microsoft.EntityFrameworkCore;
using T_Cas.Data.Entities;

namespace T_Cas.Data.DataContext
{
    public class TCasContext : DbContext
    {
        public TCasContext(DbContextOptions<TCasContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<MicUser> MicUsers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                     .HasOne(u => u.Role)
                     .WithMany()
                     .HasForeignKey(u => u.RoleId)
                     .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasOne(u => u.MicUser)
                .WithMany()
                .HasForeignKey(u => u.MicUserId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
