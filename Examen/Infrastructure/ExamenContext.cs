using ApplicationCore.Domain;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{


    public class ExamenContext:DbContext
    {
        public DbSet<Artiste> Artists { get; set; }
        public DbSet<Chanson> Chansons{ get; set; }

        public DbSet<Festival> Festivals { get; set; }
        public DbSet<Concert> Concerts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                        Initial Catalog=AhmedBelhajhasanDB;Integrated Security=true;
                                         MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

              modelBuilder.ApplyConfiguration(new FestivalConfiguration());
            modelBuilder.ApplyConfiguration( new ChansonConfiguration());
            modelBuilder.ApplyConfiguration(new ConcertConfiguration());


            // modelBuilder.Entity<Artiste>().HasMany(a => a.Festivals).WithMany(f => f.Artists).UsingEntity<Concert>();
        }

        //convention string max 50
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(50);
            base.ConfigureConventions(configurationBuilder);
        }

    }
}
