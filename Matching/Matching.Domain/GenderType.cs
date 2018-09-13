using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matching.Domain
{
    public enum GenderType
    {
        Male, Female, Other
    }
    public class Gender
    {
        public int Id { get; set; }
        public GenderType GenderType { get; set; }
    }
}
