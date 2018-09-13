using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matching.Domain
{
    public enum PeronalityCharacter
    {
        Ambitious, Active, Adventurous, BigThinking, Calm, Conservative, Emotional, Charming, Cooperative, Creative, Disciplined, Reserved, Enthusiastic, Flexible, Friendly, Helpful, Lyrical, Logical, Observant, Perfectionist, Punctual, Rational, Romantic, Sentimental, Spontaneous,Sporting, Trusting, Winning
    }
    public class Personality
    {
        public int Id { get; set; }

        public List<PersonPersonality> PersonPersonalities { get; set; }
        public PeronalityCharacter PeronalityTraits { get; set; }

    }
}
