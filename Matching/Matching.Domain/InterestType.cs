using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matching.Domain
{
    public enum PersonInterest
    {
        CouchPotato, OntheFly, Adventurous,
    }

    public class InterestType
    {
        public int Id { get; set; }

        public List<Interests> Interests { get; set; }
        public PersonInterest PersonInterest { get; set; }

    }
}