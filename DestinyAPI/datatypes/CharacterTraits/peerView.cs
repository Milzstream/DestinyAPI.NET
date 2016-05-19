using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinyAPI.datatypes.CharacterTraits
{
    public sealed class PeerView
    {
        public List<Equipment> equipment { get; set; }
    }

    public struct Equipment
    {
        public String itemHash { get; set; }
        public List<Dyes> dyes { get; set; }
    }

    public struct Dyes
    {
        public String channelHash { get; set; }
        public String dyeHash { get; set; }
    }
}
