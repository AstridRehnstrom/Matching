using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matching.Domain
{
    public class Occupation
    {
        public int Id { get; set; }
        public OccupationType occupation { get; set; }
        public Person Person { get; set; }
        
    }
}
