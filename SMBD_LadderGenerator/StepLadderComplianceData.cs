using System;

namespace SMBD_LadderGenerator
{
    internal class StepLadderComplianceData : ILadderComplianceData
    {
        public int[] MinMaxVerticalHeight { get; private set; } = { 600, 6000 };
        public int[] MinMaxSlope { get; private set; } = { 60, 70 };
        public int[] MinMaxInternalWidth { get; private set; } = { 450, 750 };
        public int[] MinMaxStepSpacing { get; private set; } = { 200, 300 };

        public override string ToString()
        {
            return String.Format("Step Ladder Compliance Data to AS1657");
        }
    }
}

// Future Implementaion
// Data to be set by reading external config file/DB
