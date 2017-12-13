using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crux.RandomGun
{
    public class RandomRaidGunSwitch
    {
        public static Random rng = new Random();

        public static void RaidingEnabled(UnturnedPlayer caller)
        {
            UnturnedPlayer player = caller;

            switch (rng.Next(1, 53 + 1))
            {
                case 1:
                    player.GiveItem(4, 1);
                    UnturnedChat.Say($"{caller.DisplayName} has recieved an Eaglefire ");
                    break;

                case 2:
                    player.GiveItem(18, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Timberwolf");
                    break;

                case 3:
                    player.GiveItem(97, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Colt");
                    break;

                case 4:
                    player.GiveItem(99, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Cobra");
                    break;

                case 5:
                    player.GiveItem(101, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Scofield");
                    break;

                case 6:
                    player.GiveItem(107, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved an Ace ");
                    break;

                case 7:
                    player.GiveItem(109, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Hawkhound");
                    break;

                case 8:
                    player.GiveItem(112, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Bluntforce");
                    break;

                case 9:
                    player.GiveItem(116, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Honeybadger");
                    break;

                case 10:
                    player.GiveItem(122, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Zubeknakov");
                    break;

                case 11:
                    player.GiveItem(129, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Snayperskya");
                    break;

                case 12:
                    player.GiveItem(297, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Grizzly");
                    break;

                case 13:
                    player.GiveItem(300, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Shadowstalker");
                    break;

                case 14:
                    player.GiveItem(346, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Crossbow");
                    break;

                case 15:
                    player.GiveItem(353, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Maple Bow");
                    break;

                case 16:
                    player.GiveItem(355, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Birch Bow");
                    break;

                case 17:
                    player.GiveItem(356, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Pine Bow");
                    break;

                case 18:
                    player.GiveItem(357, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Compound Bow");
                    break;

                case 19:
                    player.GiveItem(363, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Maplestrike");
                    break;

                case 20:
                    player.GiveItem(380, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Masterkey");
                    break;

                case 21:
                    player.GiveItem(474, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Maple Rifle");
                    break;

                case 22:
                    player.GiveItem(479, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Birch Rifle");
                    break;

                case 23:
                    player.GiveItem(480, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Pine Rifle");
                    break;

                case 24:
                    player.GiveItem(484, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Sportshot");
                    break;

                case 25:
                    player.GiveItem(1000, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Matamorez");
                    break;

                case 26:
                    player.GiveItem(1018, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Sabertooth");
                    break;

                case 27:
                    player.GiveItem(1021, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved an Avenger");
                    break;

                case 28:
                    player.GiveItem(1024, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved an Peacemaker");
                    break;

                case 29:
                    player.GiveItem(1027, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Viper");
                    break;

                case 30:
                    player.GiveItem(1037, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Heartbreaker");
                    break;

                case 31:
                    player.GiveItem(1039, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Kryzkarek");
                    break;

                case 32:
                    player.GiveItem(1041, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Yuri");
                    break;

                case 33:
                    player.GiveItem(1143, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Sawed-Off");
                    break;

                case 34:
                    player.GiveItem(1165, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Nailgun");
                    break;

                case 35:
                    player.GiveItem(1337, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Paintball Gun");
                    break;

                case 36:
                    player.GiveItem(1360, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Teklowvka");
                    break;

                case 37:
                    player.GiveItem(1362, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved an Augewehr");
                    break;

                case 38:
                    player.GiveItem(1366, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Vonya");
                    break;

                case 39:
                    player.GiveItem(1369, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Bulldog");
                    break;

                case 40:
                    player.GiveItem(1375, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Fusilaut");
                    break;

                case 41:
                    player.GiveItem(1377, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Nightraider");
                    break;

                case 42:
                    player.GiveItem(1379, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Calling Card");
                    break;

                case 43:
                    player.GiveItem(1382, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved an Ekho");
                    break;

                case 44:
                    player.GiveItem(1436, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Quadbarrel");
                    break;

                case 45:
                    player.GiveItem(1447, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Scalar");
                    break;

                case 46:
                    player.GiveItem(1476, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Luger");
                    break;

                case 47:
                    player.GiveItem(1477, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Maschinengewehr");
                    break;

                case 48:
                    player.GiveItem(1480, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Determinator");
                    break;

                case 49:
                    player.GiveItem(1481, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved an Emire");
                    break;

                case 50:
                    player.GiveItem(1484, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Devil's Bane");
                    break;

                case 51:
                    player.GiveItem(1488, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Swissgewher");
                    break;

                case 52:
                    player.GiveItem(488, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Desert Falcon");
                    break;

                case 53:
                    player.GiveItem(132, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Dragonfang! Prepare your bases.");
                    break;

                case 54:
                    player.GiveItem(126, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Nykorev! Prepare your bases.");
                    break;

                case 55:
                    player.GiveItem(519, 1);
                    UnturnedChat.Say($"{player.DisplayName} has recieved a Dragonfang! Prepare your bases.");
                    break;

                default:
                    UnturnedChat.Say($"{player.DisplayName} got unlucky and recieved nothing :(");
                    break;
            }
        }

        

        
    }
}
