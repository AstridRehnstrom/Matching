using Matching.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Match.Data
{
    public class MatchMainData : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Personality> Personality { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Server = (localdb)\\mssqllocaldb; Database = MatchingDataBase;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.Entity<PersonPersonality>()

                .HasKey(x => new { x.PersonId, x.PersonalityId });
        }
    }
}
