using System;
using System.Collections.Generic;

namespace Matching.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public GenderType Gender { get; set; }

        public List<PersonPersonality> IntrestedInGenders { get; set; }
        public List<Interests> Intrestes { get; set; }
        public List<Education> Educations { get; set; }
        public List<Occupation> Occupations { get; set; }
        public List<Complexion> Complexions { get; set; }
        public List<Family> Family { get; set; }


    }
}
