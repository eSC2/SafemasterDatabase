using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBD_LadderGenerator
{

    internal class LadderType
    {
        public int InputLadderVerticalHeight { get; set; }
        public int InputLadderWidth { get; set; }
        public int InputLadderPitch { get; set; }
        public string InputLadderType { get; set; }

        public LadderType(int inputLadderVHeight, int inputLadderWidth, int inputLadderPitch, string inputLadderType)
        {
            this.InputLadderVerticalHeight = inputLadderVHeight;
            this.InputLadderWidth = inputLadderWidth;
            this.InputLadderPitch = inputLadderPitch;
            this.InputLadderType = inputLadderType;
        }

        public bool CompareStandards()
        {
            bool ladderComplies = false;

            switch (InputLadderType)
            {
                case "rungLadder":
                    break;

                case "stepLadder":
                    break;

                case "stairCase":
                    break;

                default:
                    break;
            }

            return ladderComplies;
        }
    }
}
