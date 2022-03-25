using System;
using System.Collections.Generic;

namespace SMBD_LadderGenerator
{
    internal class RungLadderCheck : InputComplianceCheck, ILadderComplianceData
    {
        static int[] MinMaxVerticalHeight { get; } = { 500, 6000 };
        static int[] MinMaxInternalWidth { get; } = { 375, 525 };
        static int[] MinMaxPitch { get; } = { 70, 90 };
        static int[] MinMaxStepSpacing { get; } = { 250, 300 };

        public static bool CheckInputCompliance(List<int> userInput)
        {
            return ComplianceCheck(MinMaxVerticalHeight, MinMaxInternalWidth, MinMaxPitch, userInput);
        }

        public override string ToString()
        {
            return String.Format("Check user input to Rung Ladder Compliance Data AS1657");
        }
    }
}

// Future Implementaion
// Data to be set by reading external config file/DB
