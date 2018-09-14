using System;
using System.Linq;
using Application;
using Match.Data;
using Matching.Domain;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using Console = Colorful.Console;
using System.Threading;

namespace Matching
{
    class Program
    {
        static MatchMainData MatchData = new MatchMainData();
        static void Main(string[] args)
        {

           
            Console.WriteLine("Dating-App", Color.DeepPink);
           
            //DataInput.ClearDatabase();
            //DataInput.AddPersonWithData();
            ListAllPersonsWithSameInterests(PersonInterest.Literature);
            ListAllPersonsWithSameInterests(PersonInterest.Movie);
            ListAllPersonsWithSamePersonality(PeronalityCharacter.Charming);
            ListAllPersonsWithSamePersonality(PeronalityCharacter.Creative);
            System.Console.WriteLine();
            Thread.Sleep(8000);
            Console.Clear();
            UserInformation();
        }

        private static void UserInformation()
        {
            while (true)
            {
               
                System.Console.WriteLine();
                Console.WriteLine("".PadRight(20) + "Welcome to Matching Database enter following information to search for match", Color.DeepPink);
                Console.Write("Enter your Name:");
                string input1 = Console.ReadLine();
                Console.Write("Enter your age:");
                int input2 = int.Parse(Console.ReadLine());
                Console.Write("Enter gender:");
                string input3 = Console.ReadLine();
                Console.Write("Thank you for infomation:");
                System.Console.WriteLine(input1);
                Console.WriteLine();
                Console.WriteLine("Select one of  following catogories for seaach for match", Color.DeepPink);


                System.Console.WriteLine();
                Console.WriteLine("\tenter A " + "Match with Education", Color.BurlyWood);
                Console.WriteLine("\tenter B " + "Match with personality", Color.BurlyWood);
                Console.WriteLine("\tenter C " + "Match with Interest", Color.BurlyWood);
                Console.WriteLine("\tenter D " + "Match with Occupation", Color.BurlyWood);
                ConsoleKey command = Console.ReadKey().Key;
                switch (command)
                {

                    case ConsoleKey.A: MatchingWithEducation(); break;
                    case ConsoleKey.B: MatchingWithPersonality(); break;
                    case ConsoleKey.C: MatchingWithInterest(); break;
                    case ConsoleKey.D: MatchingWithOccupation(); break;
                }

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
                    Console.WriteLine(string.Join(",\n", Enum.GetNames(typeof(OccupationType))),Color.Green);

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
            else
            {
                Console.WriteLine("Congradulations we find match for you");
                foreach (var item in c)
                {


                    Console.WriteLine("Matchs name".PadRight(15) + item.FirstName, Color.IndianRed);
                }
            }


        }

        private static void MatchingWithInterest()
        {
            PersonInterest choice;
            System.Console.WriteLine("\n");
            while (true)
            {
                try
                {
                    Console.WriteLine("Seelct your interest catogory");
                    Console.WriteLine(string.Join(",\n", Enum.GetNames(typeof(PersonInterest))), Color.Green);

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
            else
            {
                Console.WriteLine("Congradulations we find match for you");
                foreach (var item in c)
                {


                    Console.WriteLine("Matchs name".PadRight(15) + item.FirstName, Color.IndianRed);
                }
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
                    Console.WriteLine(string.Join(",\n", Enum.GetNames(typeof(PeronalityCharacter))), Color.Green);

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
            if (c.Count == 0)
            {
                Console.WriteLine("Sorry no match find");
            }
            else
            {
                Console.WriteLine("Congradulations we find match for you");
                foreach (var item in c)
                {


                    Console.WriteLine("Matchs name".PadRight(15) + item.FirstName, Color.IndianRed);
                }
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
                    Console.WriteLine(string.Join(",\n", Enum.GetNames(typeof(EducationType))), Color.Green);

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
            if (c.Count == 0)
            {
                Console.WriteLine("Sorry no match find");
               
            }
            else
            {
                Console.WriteLine("Congradulations we find match for you");
                foreach (var item in c)
                {

                    
                    Console.WriteLine("Matchs name".PadRight(15) + item.FirstName,Color.IndianRed);
                }
            }
                               

        }

        private static void ListAllPersonsWithSamePersonality(PeronalityCharacter personalityTrait)
        {
            Console.ForegroundColor = Color.DarkMagenta;
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
            Console.ForegroundColor = Color.DarkMagenta;
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
