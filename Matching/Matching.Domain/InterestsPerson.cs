using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matching.Domain
{
    public class InterestsPerson
    {
        public int InterestsId { get; set; }
        public Interests Interests{ get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
