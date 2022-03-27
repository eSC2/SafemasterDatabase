using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBD_LadderGenerator
{
    internal class RungLadder : LadderSystem
    {
        public RungLadder(int ladderVH, int ladderW, int ladderP) : base(ladderVH, ladderW, ladderP)
        {
            LadderBodyLength = LadderCalcFx.BodyLength(ladderP, ladderVH);
            NumberOfSteps = LadderCalcFx.NumOfSteps(LadderBodyLength, 300);
        }
    }
}
