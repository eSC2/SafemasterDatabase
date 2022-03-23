using System;
using System.Collections.Generic;

namespace SMBD_LadderGenerator
{
    internal class RungLadderComplianceData : ILadderComplianceData
    {
        public int MaxVerticalHeight { get; private set; } = 6000;
        public int MinVerticalHeight { get; private set; } = 500;
        public int MaxSlope { get; private set; } = 90;
        public int MinSlope { get; private set; } = 70;
        public int MaxInternalWidth { get; private set; } = 525;
        public int MinInternalWidth { get; private set; } = 375;
        public int MaxStepSpacing { get; private set; } = 300;
        public int MinStepSpacing { get; private set; } = 250;

        public override string ToString()
        {
            return String.Format("Rung Ladder Compliance Data to AS1657");
        }
    }
}

// Future Implementaion
// Data to be set by reading external config file/DB
