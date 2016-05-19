using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinyAPI.datatypes.CharacterTraits
{
    public sealed class Inventory
    {
        /// <summary>
        ///  Not sure if used anymore, or what it represents, mail maybe?
        /// </summary>
        public object items { get; set; }
        public List<Currency> currencies { get; set; }
    }
}
