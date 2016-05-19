using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinyAPI.datatypes.CharacterTraits
{
    public sealed class Character
    {
        public CharacterBase characterBase { get; set; }
        public String emblemPath { get; set; }
        public String backgroundPath { get; set; }
        public String emblemHash { get; set; }
        public int characterLevel { get; set; }
        public int baseCharacterLevel { get; set; }
        public Boolean isPrestigeLevel { get; set; }
        public double percentToNextLevel { get; set; }
        public LevelProgression levelProgression { get; set; }
    }
}
