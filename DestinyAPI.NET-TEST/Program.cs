using DestinyAPI;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerSearch search = new PlayerSearch("[API KEY FROM BUNGIE]");
            List<DestinyPlayer> players = search.FindPlayers(PLATFORM.All, "shadeslayor");

            PlayerInfo info = new PlayerInfo("[API KEY FROM BUNGIE]");
            DestinyPlayer player = info.GetPlayerInfo(PLATFORM.TigerXbox, players[0].membershipId);
            Console.WriteLine(player.characters[0].characterBase.classType.ToString());
            Console.Read();
        }
    }
}

