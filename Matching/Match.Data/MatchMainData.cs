using Matching.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Match.Data
{
    public class MatchMainData: DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Server = (localdb)\\mssqllocaldb; Database = MatchingDataBase;");
        }
    }
}
