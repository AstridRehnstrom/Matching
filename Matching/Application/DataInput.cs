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


            var person1 = new Person
            {
                NickName = "Renu",
                FirstName = "Renuka",
                LastName = "Crook",
                Age = 24,
                Gender = GenderType.Female,

                ContactInfo = new ContactInfo
                {
                    Adress = "västberga alle 20",
                    Email = "renu@hotmail.com",
                    Location = "Stockholm",
                },
                IntrestedInGenders = new List<Gender>
                {
                    new Gender { GenderType = GenderType.Male}

                },
                Educations = new List<Education>
                {
                    new Education{ EducationType=EducationType.HighSchool }
                },
                Occupations = new List<Occupation>
                {
                   new Occupation{ occupation=OccupationType.BetweenJiob}
                },
                Complexions = new List<Complexion>
                {
                    new Complexion{ BodyType=BodyType.Sporty, HairColor=HairColor.Brown, SkinColor=SkinColor.Black}
                },
                Family = new List<Family>
                {
                    new Family{  HaveAnimal=true, HaveChildren=true}
                },
                InterestsPerson = new List<InterestsPerson>
                {
                    new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.Literature}
                    },
                     new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.Travel}
                    }

                },
                PersonPersonalities = new List<PersonPersonality>
                {
                    new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Calm}

                         },
                     new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Cooperative}

                         },
                      new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Emotional }

                         }
                }
            };
            var person2 = new Person
            {
                NickName = "Lo",
                FirstName = "Laurien",
                LastName = "Samsson",
                Age = 40,
                Gender = GenderType.Female,

                ContactInfo = new ContactInfo
                {
                    Adress = "Hornsgatan 20",
                    Email = "Laurien@hotmail.com",
                    Location = "Stockholm",
                },
                IntrestedInGenders = new List<Gender>
                {
                    new Gender { GenderType = GenderType.Female}

                },
                Educations = new List<Education>
                {
                    new Education{ EducationType=EducationType.Academic }
                },
                Occupations = new List<Occupation>
                {
                   new Occupation{ occupation=OccupationType.HealthcareAndMedicine}
                },
                Complexions = new List<Complexion>
                {
                    new Complexion{ BodyType=BodyType.Average, HairColor=HairColor.Blonde, SkinColor=SkinColor.White}
                },
                Family = new List<Family>
                {
                    new Family{  HaveAnimal=false, HaveChildren=false}
                },
                InterestsPerson = new List<InterestsPerson>
                {
                    new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.HealtExercise}
                    },
                     new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.Music}
                    }

                },
                PersonPersonalities = new List<PersonPersonality>
                {
                    new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Adventurous }

                         },
                     new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Flexible }

                         },
                      new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Friendly }

                         }
                }
            };
            var person3 = new Person
            {
                NickName = "Stephen",
                FirstName = "Stev",
                LastName = "Thilaka",
                Age = 32,
                Gender = GenderType.Male,

                ContactInfo = new ContactInfo
                {
                    Adress = "Brovägen 8",
                    Email = "lolloA@hotmail.com",
                    Location = "Stockholm",
                },
                IntrestedInGenders = new List<Gender>
                {
                    new Gender { GenderType = GenderType.Male}

                },
                Educations = new List<Education>
                {
                    new Education{ EducationType=EducationType.School }
                },
                Occupations = new List<Occupation>
                {
                   new Occupation{ occupation=OccupationType.Service}
                },
                Complexions = new List<Complexion>
                {
                    new Complexion{ BodyType=BodyType.Sporty, HairColor=HairColor.Black, SkinColor=SkinColor.Pale}
                },
                Family = new List<Family>
                {
                    new Family{  HaveAnimal=true, HaveChildren=false}
                },
                InterestsPerson = new List<InterestsPerson>
                {
                    new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.FoodNDrink}
                    },
                     new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.Travel}
                    }

                },
                PersonPersonalities = new List<PersonPersonality>
                {
                    new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Enthusiastic }

                         },
                     new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Emotional }

                         },
                      new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Helpful }

                         }
                }
            };
            var person4 = new Person {
                NickName = "Lollo",
                FirstName = "Louise",
                LastName = "Bark",
                Age = 38,
                Gender = GenderType.Female,

                ContactInfo = new ContactInfo
                {
                    Adress = "Brovägen 8",
                    Email = "lolloA@hotmail.com",
                    Location = "Stockholm",
                },
                IntrestedInGenders = new List<Gender>
                {
                    new Gender { GenderType = GenderType.Male}

                },
                Educations = new List<Education>
                {
                    new Education{ EducationType=EducationType.Univercity }
                },
                Occupations = new List<Occupation>
                {
                   new Occupation{ occupation=OccupationType.Business}
                },
                Complexions = new List<Complexion>
                {
                    new Complexion{ BodyType=BodyType.Sporty, HairColor=HairColor.Brown, SkinColor=SkinColor.Pale}
                },
                Family = new List<Family>
                {
                    new Family{  HaveAnimal=false, HaveChildren=true}
                },
                InterestsPerson = new List<InterestsPerson>
                {
                    new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.Movie}
                    },
                     new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.Music}
                    }

                },
                PersonPersonalities = new List<PersonPersonality>
                {
                    new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Adventurous }

                         },
                     new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.BigThinking }

                         },
                      new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Charming }

                         }
                }
            };

            var person5 = new Person {
                NickName = "Bollen",
                FirstName = "Bo",
                LastName = "Bosson",
                Age = 45,
                Gender = GenderType.Male,

                ContactInfo = new ContactInfo
                {
                    Adress = "Storgatan 8",
                    Email = "bollenA@hotmail.com",
                    Location = "Stockholm",
                },
                IntrestedInGenders = new List<Gender>
                {
                    new Gender { GenderType = GenderType.Male}

                },
                Educations = new List<Education>
                {
                    new Education{ EducationType=EducationType.HighSchool }
                },
                Occupations = new List<Occupation>
                {
                   new Occupation{ occupation=OccupationType.HealthcareAndMedicine}
                },
                Complexions = new List<Complexion>
                {
                    new Complexion{ BodyType=BodyType.Thin, HairColor=HairColor.Brown, SkinColor=SkinColor.Brown}
                },
                Family = new List<Family>
                {
                    new Family{  HaveAnimal=true, HaveChildren=false}
                },
                InterestsPerson = new List<InterestsPerson>
                {
                    new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.Movie}
                    },
                    new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.HealtExercise}
                    },
                    new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.Literature}
                    }

                },
                PersonPersonalities = new List<PersonPersonality>
                {
                    new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Charming }

                         },
                     new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Conservative }

                         },
                      new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Disciplined }

                         }
                }

            };

            var person6 = new Person {
                NickName = "Ubbe",
                FirstName = "Urban",
                LastName = "Larsson",
                Age = 32,
                Gender = GenderType.Male,

                ContactInfo = new ContactInfo
                {
                    Adress = "Drottninggatan 4",
                    Email = "ubbe@gmail.com",
                    Location = "Stockholm",
                },
                IntrestedInGenders = new List<Gender>
                {
                    new Gender { GenderType = GenderType.Female}

                },
                Educations = new List<Education>
                {
                    new Education{ EducationType=EducationType.HighSchool }
                },
                Occupations = new List<Occupation>
                {
                   new Occupation{ occupation=OccupationType.ArtsAndEntertainment}
                },
                Complexions = new List<Complexion>
                {
                    new Complexion{ BodyType=BodyType.Average, HairColor=HairColor.Blonde, SkinColor=SkinColor.Pale}
                },
                Family = new List<Family>
                {
                    new Family{  HaveAnimal=false, HaveChildren=true}
                },
                InterestsPerson = new List<InterestsPerson>
                {
                    new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.Literature}
                    },
                    new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.Movie}
                    },
                    new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.Travel}
                    },
                    new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.HealtExercise}
                    }

                },
                PersonPersonalities = new List<PersonPersonality>
                {
                    new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Punctual }

                         },
                     new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Creative }

                         },
                      new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Charming }

                         },
                       new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.BigThinking }

                         }
                }


            };
            var person7 = new Person { };
            var person8 = new Person { };
            var person9 = new Person { };
            var person10 = new Person
            {
                NickName = "Gurra",
                FirstName = "Gunnar",
                LastName = "Larsson",
                Age = 58,
                Gender = GenderType.Male,

                ContactInfo = new ContactInfo
                {
                    Adress = "Götgatan 45",
                    Email = "gurraA@hotmail.com",
                    Location = "Stockholm",
                },
                IntrestedInGenders = new List<Gender>
                {
                    new Gender { GenderType = GenderType.Male}

                },
                Educations = new List<Education>
                {
                    new Education{ EducationType=EducationType.HighSchool }
                },
               Occupations = new List<Occupation>
                {
                   new Occupation{ occupation=OccupationType.BetweenJiob}
                },
               Complexions = new List<Complexion>
                {
                    new Complexion{ BodyType=BodyType.Thin, HairColor=HairColor.Red, SkinColor=SkinColor.Pale}
                },
               Family = new List<Family>
                {
                    new Family{  HaveAnimal=false, HaveChildren=false}
                },
               InterestsPerson = new List<InterestsPerson>
                {
                    new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.Literature}
                    }

                },
               PersonPersonalities = new List<PersonPersonality>
                {
                    new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Punctual }

                         }
                }



           };
           var person11 =new Person
           {
               NickName = "Emmy",
               FirstName = "Emma-Lisa",
               LastName = "Svensson",
               Age = 22,
               Gender = GenderType.Female,

               ContactInfo = new ContactInfo
               {
                   Adress = "Stora Svängen 73",
                   Email = "emmy96@gmail.com",
                   Location = "Göteborg",
               },
               IntrestedInGenders = new List<Gender>
                {
                    new Gender { GenderType = GenderType.Female}

                },
               Educations = new List<Education>
                {
                    new Education{ EducationType=EducationType.HighSchool }
                },
               Occupations = new List<Occupation>
                {
                   new Occupation{ occupation=OccupationType.LawEnforcementAndArmedForces}
                },
               Complexions = new List<Complexion>
                {
                    new Complexion{ BodyType=BodyType.Average, HairColor=HairColor.Brown, SkinColor=SkinColor.Brown}
                },
               Family = new List<Family>
                {
                    new Family{  HaveAnimal=true, HaveChildren=false}
                },
               InterestsPerson = new List<InterestsPerson>
                {
                    new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.HealtExercise}
                    }

                },
               PersonPersonalities = new List<PersonPersonality>
                {
                    new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Spontaneous }

                         }
                }




           };
           var person12 = new Person
           {
               NickName = "Fredda",
               FirstName = "Fredrik",
               LastName = "Berghed",
               Age = 34,
               Gender = GenderType.Male,

               ContactInfo = new ContactInfo
               {
                   Adress = "Klostergatan 4",
                   Email = "fredrik.berghed@tele2.se",
                   Location = "Göteborg",
               },
               IntrestedInGenders = new List<Gender>
                {
                    new Gender { GenderType = GenderType.Male}

                },
               Educations = new List<Education>
                {
                    new Education{ EducationType=EducationType.Univercity }
                },
               Occupations = new List<Occupation>
                {
                   new Occupation{ occupation=OccupationType.ScienceAndTechnology}
                },
               Complexions = new List<Complexion>
                {
                    new Complexion{ BodyType=BodyType.Sporty, HairColor=HairColor.Blonde, SkinColor=SkinColor.White}
                },
               Family = new List<Family>
                {
                    new Family{  HaveAnimal=false, HaveChildren=true}
                },
               InterestsPerson = new List<InterestsPerson>
                {
                    new InterestsPerson{
                        Interests=new Interests{PersonInterest=PersonInterest.HealtExercise}
                    }

                },
               PersonPersonalities = new List<PersonPersonality>
                {
                    new  PersonPersonality{
                         Personality=new  Personality{   PeronalityTraits=PeronalityCharacter.Sporting }

                         }
                }





           };




            using (var context = new MatchMainData())

            {

                context.Persons.AddRange(person,person1,person2,person3,person4,person5,person6,person7,person8,person9,person10,person11,person12);


                context.SaveChanges();
            }
        }
        
        public static  void ClearDatabase()
        {
            

            using (var context = new MatchMainData())
            {

                foreach (var item in context.Genders)
                {

                    context.Remove(item);

                }

                foreach (var item in context.Persons)
                {
                   
                    context.Remove(item);


                }
                foreach (var item in context.Interests)
                {

                    context.Remove(item);

                }
                foreach (var item in context.Occupations)
                {

                    context.Remove(item);

                }
                foreach (var item in context.Educations)
                {

                    context.Remove(item);

                }
                foreach (var item in context.Families)
                {

                    context.Remove(item);

                }
                foreach (var item in context.ContactInfos)
                {

                    context.Remove(item);

                }
                foreach (var item in context.Complexions)
                {

                    context.Remove(item);

                }
                foreach (var item in context.Personalities)
                {

                    context.Remove(item);

                }

                context.SaveChanges();
            }


           
        }
        

    }
}
