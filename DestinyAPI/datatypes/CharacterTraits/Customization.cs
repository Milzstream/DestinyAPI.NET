using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinyAPI.datatypes.CharacterTraits
{
    public sealed class Customization
    {
        public String personality { get; set; }
        public String face { get; set; }
        public String skinColor { get; set; }
        public String lipColor { get; set; }
        public String eyeColor { get; set; }
        public String hairColor { get; set; }
        public String featureColor { get; set; }
        public String decalColor { get; set; }
        public Boolean wearHelmet { get; set; }
        public int hairIndex { get; set; }
        public int featureIndex { get; set; }
        public int decalIndex { get; set; }
    }
}
