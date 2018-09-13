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
                Educations= new List<Education>
                {
                    new Education{ EducationType=EducationType.School}
                },
                Occupations=new List<Occupation>
                {
                   new Occupation{ occupation=OccupationType.Student}
                },
                Complexions=new List<Complexion>
                {
                    new Complexion{ BodyType=BodyType.Average, HairColor=HairColor.Black, SkinColor=SkinColor.Pale}
                },
                Family= new List<Family>
                {
                    new Family{  HaveAnimal=true, HaveChildren=false}
                },
               

            };

            using (var context = new MatchMainData())

            {
                context.Persons.Add(person);
                context.SaveChanges();
            }
        }

    }
}
