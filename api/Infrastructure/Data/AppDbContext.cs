using Common.Utils;
using Domain.Entities.Identity;
using Domain.Entities.Sample;
using Domain.ValueObjects.Sample;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Sound> Sounds { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Instrument> Instruments { get; set; }

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
             * 
             * This shall be automated.
             */
            optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn)/*, x => x.MigrationsAssembly("Domain")*/);
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // This goes for every Value Object
            modelBuilder.Entity<Sound>()
                .OwnsOne(o => o.Key)
                .Property(s => s.Root)
                .HasConversion(new Converter<Note>());

            modelBuilder.Entity<Sound>()
                .OwnsOne(o => o.Key)
                .Property(s => s.Mod)
                .HasConversion(new Converter<Modification>());

            modelBuilder.Entity<Sound>()
                .OwnsOne(o => o.Key)
                .Property(s => s.Form)
                .HasConversion(new Converter<Form>());

            string[] musicGenres = {
                "Rock",
                "Pop",
                "Jazz",
                "Classical",
                "Metal",
                "Country",
                "Rap",
                "Hip Hop",
                "Reggae",
                "Blues",
                "Folk",
                "Soul",
                "Electronic",
                "Funk",
                "Disco",
                "Punk",
                "Indie",
                "R&B"
            };

            modelBuilder.Entity<Genre>()
                .HasData(musicGenres.Select((genre, i) => new { 
                        Id = ++i,
                        Name = genre,
                    })
                );

            string[] instruments = {
                "Guitar",
                "Bass",
                "Drums",
                "Piano",
                "Keyboard",
                "Violin",
                "Saxophone",
                "Trumpet",
                "Trombone",
                "Flute",
                "Clarinet"
            };

            modelBuilder.Entity<Instrument>()
                .HasData(instruments.Select((instrument, i) => new {
                        Id = ++i,
                        Name = instrument,
                    })
                );
        }
    }
}
