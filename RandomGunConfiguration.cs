using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Crux.RandomGun
{
    public class RandomGunConfiguration : IRocketPluginConfiguration
    {
        public bool EnablePlugin;

        public bool GiveGunOnJoin;
        public float GunOnJoinCooldown;

        public string Mode;

        public void LoadDefaults()
        {
            EnablePlugin = true;

            GiveGunOnJoin = false;
            GunOnJoinCooldown = 86400;

            Mode = "default";
        }
    }
}
