using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBD_LadderGenerator
{
    /// <summary>
    /// Child class RungLadder of Base class LadderTypeBase
    /// </summary>
    internal class GenerateRungLadder : LadderTypeBase
    {
        public int LadderTopStile { get; set; }

        /// <summary>
        /// Creates new RungLadder object
        /// </summary>
        /// <param name="inputLadderVHeight">User input vertical height</param>
        /// <param name="inputLadderWidth">User input ladder internal width</param>
        /// <param name="inputLadderPitch">User input ladder pitch</param>
        public GenerateRungLadder(int inputLadderVHeight, int inputLadderWidth, int inputLadderPitch) : base(inputLadderVHeight, inputLadderWidth, inputLadderPitch)
        {
            this.LadderType = "Rung Ladder";

            if (inputLadderPitch == 90)
                this.LadderTopStile = 1350;
            else
                this.LadderTopStile = 1065;
        }
    }
}
