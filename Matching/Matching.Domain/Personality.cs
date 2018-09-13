using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matching.Domain
{
    public enum PeronalityCharacter
    {
        Ambitious, Active
    }
    public class Personality
    {
        public int Id { get; set; }

        public List<PersonPersonality> PersonPersonalities { get; set; }
        public PeronalityCharacter PeronalityTraits { get; set; }

    }
}
