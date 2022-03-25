using System;
using System.Collections.Generic;

namespace SMBD_LadderGenerator
{
    internal class StepLadderCheck : InputComplianceCheck, ILadderComplianceData
    {
        static int[] MinMaxVerticalHeight { get; } = { 600, 6000 };
        static int[] MinMaxInternalWidth { get; } = { 450, 750 };
        static int[] MinMaxPitch { get; } = { 60, 70 };
        static int[] MinMaxStepSpacing { get; } = { 200, 300 };

        public static bool CheckInputCompliance(List<int> userInput)
        {
            return ComplianceCheck(MinMaxVerticalHeight, MinMaxInternalWidth, MinMaxPitch, userInput);
        }

        public override string ToString()
        {
            return String.Format("Check user input to Step Ladder Compliance Data AS1657");
        }
    }
}

// Future Implementaion
// Data to be set by reading external config file/DB
