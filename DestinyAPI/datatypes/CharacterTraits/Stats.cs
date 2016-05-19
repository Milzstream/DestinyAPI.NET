using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinyAPI.datatypes.CharacterTraits
{
    /// <summary>
    ///     OMG Lots of Stats
    /// </summary>
    public sealed class Stats
    {
        public Stat STAT_DEFENSE { get; set; }
        public Stat STAT_INTELLECT { get; set; }
        public Stat STAT_DISCIPLINE { get; set; }
        public Stat STAT_STRENGTH { get; set; }
        public Stat STAT_LIGHT { get; set; }
        public Stat STAT_ARMOR { get; set; }
        public Stat STAT_AGILITY { get; set; }
        public Stat STAT_RECOVERY { get; set; }
        public Stat STAT_OPTICS { get; set; }
    }

    public struct Stat
    {
        public String statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }
}
