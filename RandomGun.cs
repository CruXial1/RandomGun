using Rocket.API;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Player;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Logger = Rocket.Core.Logging.Logger;

namespace Crux.RandomGun
{   
    public class RandomGun : RocketPlugin<RandomGunConfiguration>
    {
        public static RandomGun Instance;
        public static RandomGunConfiguration Config => Instance.Configuration.Instance;

        protected override void Load()
        {
            Instance = this;

            if (Config.Mode == null)
            {
                Config.Mode = "default";
            }

            Logger.Log("RandomGun Loaded!");

            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
        }

        protected override void Unload()
        {
            Logger.Log("RandomGun Unloaded!");

            U.Events.OnPlayerConnected -= Events_OnPlayerConnected;
        }

        void Events_OnPlayerConnected(UnturnedPlayer player)
        {
            StartCoroutine(StartDelayedUrlRequest(player));
        }

        private IEnumerator StartDelayedUrlRequest(UnturnedPlayer player)
        {
            yield return new WaitForSeconds(1.5f);
            if (Config.GiveGunOnJoin)
            {
                RandomGunSwitch.GiveRandomGun(player);
                yield return new WaitForSeconds(Config.GunOnJoinCooldown);
            }
        }
    }
}
