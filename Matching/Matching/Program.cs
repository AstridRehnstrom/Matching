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
        static MatchMainData MatchData = new MatchMainData();
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Dejting-Appen");
            Console.ResetColor();
            //DataInput.ClearDatabase();
            //DataInput.AddPersonWithData();
            ListAllPersonsWithSameInterests(PersonInterest.Literature);
            ListAllPersonsWithSameInterests(PersonInterest.Movie);
            UserInformation();
        }

        private static void UserInformation()
        {
            Console.WriteLine("Welcome to Matching enter following information for search for match");
            Console.WriteLine("Enter your Name");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter gender");
            string input3 = Console.ReadLine();
            Console.WriteLine("Thank you for infomation");
            Console.WriteLine();
            Console.WriteLine("Select one of  following catogories for seaach for match");

            Console.WriteLine("\tenter A " + "Match with Education");
            Console.WriteLine("\tenter B " + "Match with personality");
            Console.WriteLine("\tenter C " + "Match with Interest");
            Console.WriteLine("\tenter D " + "Match with Occupation");
            ConsoleKey command = Console.ReadKey().Key;
            switch (command)
            {

                case ConsoleKey.A: MatchingWithEducation(); break;
                case ConsoleKey.B: MatchingWithPersonality(); break;
                case ConsoleKey.C: MatchingWithInterest(); break;
                case ConsoleKey.D: MatchingWithOccupation(); break;

            }

        }

        private static void MatchingWithOccupation()
        {
            OccupationType choice;
            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Seelct your occupation catogory");
                    Console.WriteLine(string.Join(",\t", Enum.GetNames(typeof(OccupationType))));

                    string input = Console.ReadLine();
                    choice = Enum.Parse<OccupationType>(input);
                    break;

                }
                catch
                {
                    Console.WriteLine("Pleae enter valid value");
                    continue;
                }
            }
            var c = MatchData.Persons.Where(x => x.Occupations.Select(y => y.occupation).Contains(choice)).ToList();
            if (c.Count == null)
            {
                Console.WriteLine("Sorry no match find");
            }
            foreach (var item in c)
            {
                
                Console.WriteLine(item.NickName);
            }


        }

        private static void MatchingWithInterest()
        {
            PersonInterest choice;
            while (true)
            {
                try
                {
                    Console.WriteLine("Seelct your interest catogory");
                    Console.WriteLine(string.Join(",", Enum.GetNames(typeof(PersonInterest))));

                    string input = Console.ReadLine();
                    choice = Enum.Parse< PersonInterest>(input);
                    break;

                }
                catch
                {
                    Console.WriteLine("Pleae enter valid value");
                    continue;
                }
            }
            var c = MatchData.Persons.Where(x => x.InterestsPerson.Select(y => y.Interests.PersonInterest).Contains(choice)).ToList();
            if (c.Count == null)
            {
                Console.WriteLine("Sorry no match find");
            }
            foreach (var item in c)
            {

                Console.WriteLine(item.NickName);
            }
        }

        private static void MatchingWithPersonality()
        {
            PeronalityCharacter choice;
            while (true)
            {
                try
                {
                    Console.WriteLine("Seelct your Personality catogory");
                    Console.WriteLine(string.Join(",", Enum.GetNames(typeof(PeronalityCharacter))));

                    string input = Console.ReadLine();
                    choice = Enum.Parse<PeronalityCharacter>(input);
                    break;

                }
                catch
                {
                    Console.WriteLine("Pleae enter valid value");
                    continue;
                }
            }
            var c = MatchData.Persons.Where(x => x.PersonPersonalities.Select(y => y.Personality.PeronalityTraits).Contains(choice)).ToList();
            if (c.Count == null)
            {
                Console.WriteLine("Sorry no match find");
            }
            foreach (var item in c)
            {

                Console.WriteLine(item.NickName);
            }
        }

        private static void MatchingWithEducation()
        {
            EducationType choice;
            while (true)
            {
                try
                {
                    Console.WriteLine("Seelct your Education catogory");
                    Console.WriteLine(string.Join(",", Enum.GetNames(typeof(EducationType))));

                    string input = Console.ReadLine();
                    choice = Enum.Parse<EducationType>(input);
                    break;

                }
                catch
                {
                    Console.WriteLine("Pleae enter valid value");
                    continue;
                }
            }
            var c = MatchData.Persons.Where(x => x.Educations.Select(y => y.EducationType).Contains(choice)).ToList();
            if (c.Count == null)
            {
                Console.WriteLine("Sorry no match find");
            }
            else
            {
                foreach (var item in c)
                {

                    Console.WriteLine(item.NickName);
                }
            }
           

        }

        private static void ListAllPersonsWithSameInterests(PersonInterest interest)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Show all persons with the inteserst: " + interest);
            Console.ResetColor();
            using (var context = new MatchMainData())
            {
                foreach (var person in context.Persons
                    .Include(q => q.InterestsPerson)
                    .Where(p => p.InterestsPerson.Select(x => x.Interests.PersonInterest).Contains(interest)))
                {
                    Console.WriteLine(person.FirstName + " " + person.LastName);
                }
            }
        }
    }
}
