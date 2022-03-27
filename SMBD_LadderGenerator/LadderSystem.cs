using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBD_LadderGenerator
{

    internal class LadderSystem
    {
        int _LadderVerticalHeight { get; set; }
        int _LadderIntervalWidth { get; set; }
        int _LadderPitch { get; set; }
        int _LadderBodyLength { get; set; }
        int _NumberOfSteps { get; set; }
        int _StepDistance { get; set; }

        public LadderSystem(int ladderVH, int ladderW, int ladderP)
        {
            this._LadderVerticalHeight = ladderVH;
            this._LadderIntervalWidth = ladderW;
            this._LadderPitch = ladderP;
        }

        public int LadderBodyLength
        {
            get
            {
                return _LadderBodyLength;
            }
            protected set
            {
                _LadderBodyLength = value;
            }
        }

        public int NumberOfSteps
        {
            get
            {
                return _NumberOfSteps;
            }
            protected set
            {
                _NumberOfSteps = value;
            }
        }
    }
}
