using Rocket.API;
using System.Collections.Generic;

namespace Crux.RandomGun
{
    class GunCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "gun";

        public string Help => "Gives a player a random gun";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            if(RandomGun.Config.EnablePlugin)
            {
                if (RandomGun.Config.IncludeRaidingGuns)
                {
                    RandomRaidGunSwitch.RaidingEnabled(caller);
                    return;
                }

                if (RandomGun.Config.IncludeOverpoweredGuns)
                {
                    RandomOPGunSwitch.OPEnabled(caller);
                    return;
                }

                RandomGunSwitch.GiveRandomGun(caller);
                return;
            }
            return;
        }
    }
}
