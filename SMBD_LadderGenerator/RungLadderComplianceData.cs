using System;
using System.Collections.Generic;

namespace SMBD_LadderGenerator
{
    internal class RungLadderComplianceData : InputComplianceCheck, ILadderComplianceData
    {
        static int[] MinMaxVerticalHeight { get; } = { 500, 6000 };
        static int[] MinMaxInternalWidth { get; } = { 375, 525 };
        static int[] MinMaxPitch { get; } = { 70, 90 };
        static int[] MinMaxStepSpacing { get; } = { 250, 300 };

        private static int[][] CompData = new int[][]
        {
            MinMaxVerticalHeight, MinMaxInternalWidth, MinMaxPitch
        };

        public static bool CheckInputCompliance(int[] userInput)
        {
            bool result = ComplianceCheck(CompData, userInput);

            return result;
        }

        public override string ToString()
        {
            return String.Format("Rung Ladder Compliance Data to AS1657");
        }
    }
}

// Future Implementaion
// Data to be set by reading external config file/DB
