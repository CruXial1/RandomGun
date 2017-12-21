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
        public static UnturnedPlayer player;

        protected override void Load()
        {
            Instance = this;

            Logger.Log("RandomGun Loaded!");

            U.Events.OnPlayerConnected += Events_OnPlayerConnected;

            StartCoroutine(StartDelayedUrlRequest(player));
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
            }
        }
    }
}
