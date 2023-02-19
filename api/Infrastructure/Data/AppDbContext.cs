using Domain.Entities.Identity;
using Domain.Entities.Sample;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Sound> Sounds { get; set; }

        public AppDbContext() : base()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build()
                .GetSection("Connections:MySql")
                .GetValue<string>("Local");

            /* 
             * Due to the multi project nature of DDD, to keep the migrations on the Infrastructure,
             * you must first create the migrations with the migrations assembly pointing to the Domain,
             * to access the entities.
             * 
             * Then remove it and point the Infrastructure layer (by default) to run the migrations.
             */
            optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn)/*, x => x.MigrationsAssembly("Domain")*/);

        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            // This goes for every Value Object
            modelBuilder.Entity<Sound>()
                .OwnsOne(o => o.Key);
        }
    }
}
