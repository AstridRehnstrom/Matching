using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matching.Domain
{
    public class Complexion
    {
        public int Id { get; set; }
        public HairColor HairColor{ get; set; }
        public SkinColor SkinColor{ get; set; }
        public BodyType BodyType{ get; set; }
       
    }
}
