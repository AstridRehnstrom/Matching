using System;
using System.Linq;
using Application;
using Match.Data;
using Matching.Domain;
using Microsoft.EntityFrameworkCore;

namespace Matching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Dejting-Appen");
            Console.ResetColor();
          //DataInput.ClearDatabase();
          //DataInput.AddPersonWithData();
           ListAllPersonsWithSameInterests(PersonInterest.Literature);
           ListAllPersonsWithSameInterests(PersonInterest.Movie);
           ListAllPersonsWithSamePersonality(PeronalityCharacter.Charming);

        }

        private static void ListAllPersonsWithSamePersonality(PeronalityCharacter personalityTrait)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Show all persons with the personal trait: " + personalityTrait);
            Console.ResetColor();
            using (var context = new MatchMainData())
            {
                foreach (var person in context.Persons
                    .Include(q => q.PersonPersonalities)
                    .Where(p => p.PersonPersonalities.Select(x => x.Personality.PeronalityTraits).Contains(personalityTrait)))
                {
                    Console.WriteLine(person.FirstName + " " + person.LastName);
                }
            }
        }

        private static void ListAllPersonsWithSameInterests(PersonInterest interest)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Show all persons with the inteserst: "+ interest);
            Console.ResetColor();
            using (var context = new MatchMainData())
            {
                foreach (var person in context.Persons
                    .Include(q => q.InterestsPerson)
                    .Where(p =>  p.InterestsPerson.Select(x=>x.Interests.PersonInterest).Contains(interest)))
                {
                    Console.WriteLine(person.FirstName + " "+ person.LastName);
                }
            }
        }
    }
}
