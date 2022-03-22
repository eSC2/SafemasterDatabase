using System;
using System.Collections.Generic;


namespace SMBD_LadderGenerator
{
    internal class StairCaseComplianceData : ILadderComplianceData
    {
        public int MaxVerticalHeight { get; private set; } = 4000;
        public int MinVerticalHeight { get; private set; } = 500;
        public int MaxSlope { get; private set; } = 45;
        public int MinSlope { get; private set; } = 20;
        public int MinInternalWidth { get; private set; } = 600;
        public int MaxStepSpacing { get; private set; } = 300;
        public int MinStepSpacing { get; private set; } = 200;

        public override string ToString()
        {
            return String.Format("Stair Case Compliance Data to AS1657");
        }

    }
}

// Future Implementaion
// Data to be set by reading external config file/DB
