using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matching.Domain
{
    public class Interests
    {
        public int Id { get; set; }
        public string Music { get; set; }
        public string Literature { get; set; }
        public string Travel { get; set; }
        public string Movie { get; set; }
        public string FoodNdrinks { get; set; }
        public string HealthNExercise { get; set; }
        public string Other { get; set; }

        public Person Person { get; set; }

        public InterestType Type { get; set; }

    }
}
