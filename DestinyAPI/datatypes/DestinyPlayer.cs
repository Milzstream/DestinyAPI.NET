using DestinyAPI.datatypes.CharacterTraits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinyAPI
{
    /// <summary>
    /// This contains the Destiny Player Info (provided by Search)
    /// </summary>
    public class DestinyPlayer
    {
        public String iconPath { get; set; }
        public PLATFORM membershipType { get; set; }
        public String membershipId { get; set; }
        public String displayName { get; set; }
        public List<Character> characters { get; set; }
        public String clanName { get; set; }
        public String clanTag { get; set; }
        public Inventory inventory { get; set; }
        public int grimoirScore { get; set; }
        public int versions { get; set; }
    }
}
