using Rocket.API;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Player;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if(!Config.EnablePlugin)
            {
                return;
            }

            Instance = this;

            U.Events.OnPlayerConnected += Events_OnPlayerConnected;

            Logger.Log("RandomGun Loaded!");

            giveGun();
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
        }

        IEnumerable<WaitForSeconds> giveGun()
        {
            yield return new WaitForSeconds(Config.GunOnJoinCooldown);

            void Onjoin(IRocketPlayer caller)
            {
                if (Config.GiveGunOnJoin)
                {
                    RandomGunSwitch.GiveRandomGun(caller);

                    return;
                }
            }
            
        }
    }
}
