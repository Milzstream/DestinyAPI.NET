using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinyAPI.datatypes.CharacterTraits
{
    public sealed class CharacterBase
    {
        public String membershipId { get; set; }
        public PLATFORM membershipType { get; set; }
        public String characterId { get; set; }
        public DateTime dateLastPlayed { get; set; }
        public Int64 minutesPlayedThisSession { get; set; }
        public Int64 minutesPlayedTotal { get; set; }
        public int powerLevel { get; set; }
        public String raceHash { get; set; }
        public String genderHash { get; set; }
        public String classHash { get; set; }
        public String currentActivityHash { get; set; }
        public String lastCompletedStoryHash { get; set; }
        public int grimoireScore { get; set; }
        public int genderType { get; set; }
        public DestinyClass classType { get; set; }
        public String buildStatGroupHash { get; set; }
        public Stats stats { get; set; }
        public Customization customization { get; set; }
        public PeerView peerView { get; set; }
    }
}
