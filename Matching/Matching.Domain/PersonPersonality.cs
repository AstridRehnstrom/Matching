using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matching.Domain
{
    public class PersonPersonality
    {
        public int PersonalityId { get; set; }
        public Personality Personality { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
