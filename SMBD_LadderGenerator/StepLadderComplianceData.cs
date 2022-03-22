using System;

namespace SMBD_LadderGenerator
{
    internal class StepLadderComplianceData : ILadderComplianceData
    {
        public int MaxVerticalHeight { get; private set; } = 6000;
        public int MinVerticalHeight { get; private set; } = 600;
        public int MaxSlope { get; private set; } = 70;
        public int MinSlope { get; private set; } = 60;
        public int MaxInternalWidth { get; private set; } = 450;
        public int MinInternalWidth { get; private set; } = 750;
        public int MaxStepSpacing { get; private set; } = 300;
        public int MinStepSpacing { get; private set; } = 200;

        public override string ToString()
        {
            return String.Format("Step Ladder Compliance Data to AS1657");
        }
    }
}

// Future Implementaion
// Data to be set by reading external config file/DB
