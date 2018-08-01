using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfinityScript;

namespace nightv2
{
    public class nightv2 : BaseScript
    {

        public nightv2()
            : base()
        {
            base.PlayerConnected += PlayerConnect;
        }

        public void PlayerConnect(Entity Player)
        {
            Player.SpawnedPlayer += new Action(() =>
            {
                base.OnInterval(50, () => this.Vision(Player, "cobra_sunset3", false));
            });
        }

        public bool Vision(Entity player, string vision, bool thermal)
        {
            if (thermal)
            {
                player.Call("ThermalVisionOn", new Parameter[0]);
            }
            else
            {
                player.Call("visionsetnakedforplayer", new Parameter[]
				{
					vision,
					5
				});
            }
            return true;
        }
    }
}
