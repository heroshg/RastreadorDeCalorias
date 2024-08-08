using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RastreadorDeCalorias.API.Entities;

namespace RastreadorDeCalorias.API.Persistence
{
    public class CalorieTrackerDbContext : IdentityDbContext<User>
    {
        public CalorieTrackerDbContext(DbContextOptions<CalorieTrackerDbContext> options) : base(options)
        {}
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Activity>(entity =>
            {
                entity.HasKey(a => a.Id);
                entity.Property(a => a.Type).IsRequired().HasMaxLength(50);
                entity.Property(a => a.Duration).IsRequired();
                entity.Property(a => a.Distance).IsRequired();
                entity.Property(a => a.CaloriesBurned).IsRequired();
                entity.Property(a => a.Date).IsRequired();

                entity.HasOne(a => a.User)
                .WithMany(u => u.Activities)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            });

        }
    }
}
