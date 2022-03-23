using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBD_LadderGenerator
{

    internal class LadderTypeBase
    {
        public string LadderType { get; set; }
        public int InputLadderVerticalHeight { get; set; }
        public int InputLadderWidth { get; set; }
        public int InputLadderPitch { get; set; }

        /// <summary>
        /// Ladder object base class
        /// </summary>
        /// <param name="inputLadderVHeight">User input ladder height</param>
        /// <param name="inputLadderWidth">User input ladder width (Internal)</param>
        /// <param name="inputLadderPitch">User input ladder pitch</param>
        public LadderTypeBase(int inputLadderVHeight, int inputLadderWidth, int inputLadderPitch)
        {
            this.InputLadderVerticalHeight = inputLadderVHeight;
            this.InputLadderWidth = inputLadderWidth;
            this.InputLadderPitch = inputLadderPitch;
        }
    }
}
