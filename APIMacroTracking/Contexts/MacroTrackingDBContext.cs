using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using APIMacroTracking.Models;

namespace APIMacroTracking.Contexts
{
    public class MacroTrackingDBContext : DbContext
    {
        protected readonly IConfiguration config;

        public MacroTrackingDBContext(DbContextOptions<MacroTrackingDBContext> options, IConfiguration config) : base(options)
        {
            this.config = config;
        }

        public virtual DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString("MacroTrackingDb"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("db_datawriter");

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("ITEM_DETAILS", "dbo");

                entity.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id");

                entity.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name");

                entity.Property(x => x.Calories)
                .IsRequired()
                .HasColumnName("Calories");

                entity.Property(x => x.Protein)
                .IsRequired()
                .HasColumnName("Protein");

                entity.Property(x => x.Carbs)
                .IsRequired()
                .HasColumnName("Carbs");

                entity.Property(x => x.Fat)
                .IsRequired()
                .HasColumnName("Fat");

                entity.Property(x => x.FoodType)
                .IsRequired()
                .HasColumnName("FoodType");
            });
        }
    }
}
