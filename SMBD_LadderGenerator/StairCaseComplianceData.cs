using System;
using System.Collections.Generic;


namespace SMBD_LadderGenerator
{
    internal class StairCaseComplianceData : ILadderComplianceData
    {
        public int[] MinMaxVerticalHeight { get; private set; } = { 500, 4000 };
        public int[] MinMaxInternalWidth { get; private set; } = { 600 };
        public int[] MinMaxSlope { get; private set; } = { 20, 45 };
        public int[] MinMaxStepSpacing { get; private set; } = { 200, 300 };

        public bool CheckCompliance(int[] userInput)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return String.Format("Stair Case Compliance Data to AS1657");
        }

    }
}

// Future Implementaion
// Data to be set by reading external config file/DB
