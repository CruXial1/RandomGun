using Rocket.API;
using Rocket.Unturned.Player;
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
            UnturnedPlayer player = (UnturnedPlayer)caller;

            if (RandomGun.Config.EnablePlugin)
            {
                if (RandomGun.Config.IncludeRaidingGuns)
                {
                    RandomRaidGunSwitch.RaidingEnabled((UnturnedPlayer)caller);
                    return;
                }

                if (RandomGun.Config.IncludeOverpoweredGuns)
                {
                    RandomOPGunSwitch.OPEnabled((UnturnedPlayer)caller);
                    return;
                }

                RandomGunSwitch.GiveRandomGun((UnturnedPlayer)caller);
                return;
            }
            return;
        }
    }
}
