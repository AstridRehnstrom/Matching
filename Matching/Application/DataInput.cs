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

                }

            };

            using (var context = new MatchMainData())

            {
                context.Persons.Add(person);
                context.SaveChanges();
            }
        }

    }
}
