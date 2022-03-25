using System;
using System.Collections.Generic;


namespace SMBD_LadderGenerator
{
    internal class StairCaseCheck : InputComplianceCheck, ILadderComplianceData
    {
        static int[] MinMaxVerticalHeight { get; } = { 500, 4000 };
        static int[] MinMaxInternalWidth { get; } = { 600 };
        static int[] MinMaxPitch { get; } = { 20, 45 };
        static int[] MinMaxStepSpacing { get; } = { 200, 300 };

        public static bool CheckInputCompliance(List<int> userInput)
        {
            return ComplianceCheck(MinMaxVerticalHeight, MinMaxInternalWidth, MinMaxPitch, userInput);
        }

        public override string ToString()
        {
            return String.Format("Check user input to Stair Case Compliance Data AS1657");
        }

    }
}

// Future Implementaion
// Data to be set by reading external config file/DB
