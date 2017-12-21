using Rocket.API;
using Rocket.Unturned.Player;
using System.Collections.Generic;

using Logger = Rocket.Core.Logging.Logger;


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
            string mode = RandomGun.Config.Mode.ToLower();

                if (mode == "raidingguns")
                {
                    RandomRaidGunSwitch.RaidingEnabled((UnturnedPlayer)caller);
                    return;
                }

                if (mode == "op")
                {
                    RandomOPGunSwitch.OPEnabled((UnturnedPlayer)caller);
                    return;
                }

                if(mode == "default")
                {
                    RandomGunSwitch.GiveRandomGun((UnturnedPlayer)caller);
                    return;
                }

                Logger.LogError("Invalid mode specified. \n Current modes: \n default \n raidingguns \n op");
            return;
        }
    }
}
