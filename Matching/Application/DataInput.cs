using Match.Data;
using Matching.Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class DataInput
    {
        public static void AddPersonWithData()
        {
            var person = new Person
            {
                NickName = "Baba",
                FirstName = "Baraba",
                LastName = "Rababa",
                Age = 30,
                Gender = GenderType.Other,

                ContactInfo = new ContactInfo
                {
                    Adress = "Raratu 38",
                    Email = "baraba@rababa.com",
                    Location = "Stockholm",
                },
                IntrestedInGenders = new List<Gender>
                {
                    new Gender { GenderType = GenderType.Male }

                },
                Educations = new List<Education>
                {
                    new Education{ EducationType=EducationType.School}
                },
                Occupations = new List<Occupation>
                {
                   new Occupation{ occupation=OccupationType.Student}
                },
                Complexions = new List<Complexion>
                {
                    new Complexion{ BodyType=BodyType.Average, HairColor=HairColor.Black, SkinColor=SkinColor.Pale}
                },
                Family = new List<Family>
                {
                    new Family{  HaveAnimal=true, HaveChildren=false}
                },
                InterestsPerson = new List<InterestsPerson>
                {
                    new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.FoodNDrink}
                    }

                },
                PersonPersonalities = new List<PersonPersonality>
                {
                    new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Active }

                         }
                }


            };

            var person1 = new Person { };
            var person2 = new Person { };
            var person3 = new Person { };
            var person4 = new Person { };
            var person5 = new Person { };
            var person6 = new Person { };
            var person7 = new Person { };
            var person8 = new Person { };
            var person9 = new Person { };
           var person10= new Person { };
           var person11 =new Person { };
           var person12 = new Person { };




            using (var context = new MatchMainData())

            {

                context.Persons.AddRange(person,person1,person2,person3,person4,person5,person6,person7,person8,person9,person10,person11,person12);


                context.SaveChanges();
            }
        }
        /*
        public static  void ClearDatabase()
        {
            // För att ta bort ett objekt måste du först göra en query
            using (var context = new MatchMainData())
            {
                context.Remove(context.Persons);
                context.Remove(context.Personality);
                context.Remove(context.Interests);
                //ReseedAllTables();

                context.SaveChanges();
            }


           
        }
        */

    }
}
