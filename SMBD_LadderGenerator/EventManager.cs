using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBD_LadderGenerator
{
    // create delegate for createLadder
    internal class EventManager
    {
        public delegate void EventCreateLadder();

        public static EventCreateLadder createLadder;

        public static void TriggerCreateLadder()
        {
            if (createLadder != null)
            {
                createLadder();
            }
        }
    }
}
