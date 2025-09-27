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

    }

}