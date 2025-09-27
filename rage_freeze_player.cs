using system;
using RAGE;

namespace FreezePlayer
{

    public class Freeze : Events.Script
    {

        public Freeze()
        {
            Events.Add("FreezePlayer", PlayerFreeze);
        }

        public void PlayerFreeze(object [] args)
        {
            RAGE.Elements.Player.LocalPlayer.FreezePosition((bool)args[0]);
        }

    }

}