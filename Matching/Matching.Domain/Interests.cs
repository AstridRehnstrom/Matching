using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matching.Domain
{
    public enum PersonInterest
    {
        Music, Literature, Travel, Movie, FoodNDrink, HealtExercise, Other
    }
    public class Interests
    {
        public int Id { get; set; }

        public PersonInterest PersonInterest { get; set; }
        public Person person { get; set; }



    }
}

