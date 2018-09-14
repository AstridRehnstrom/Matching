using Matching.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Match.Data
{
    public class MatchMainData : DbContext
    {
        public DbSet<Person> Persons { get; set; }
      
        public DbSet<Interests> Interests { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Complexion> Complexions { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<Personality> Personalities { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Server = (localdb)\\mssqllocaldb; Database = MatchingDataBase;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {


            modelBuilder.Entity<PersonPersonality>()
                .HasKey(x => new { x.PersonId, x.PersonalityId });

            modelBuilder.Entity<InterestsPerson>()

                .HasKey(x => new { x.PersonId, x.InterestsId });
        }

    }
}
