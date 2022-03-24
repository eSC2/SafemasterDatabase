using System;

namespace SMBD_LadderGenerator
{
    internal class RungLadderCheck : InputComplianceCheck
    {
        static int[] MinMaxVerticalHeight { get; } = { 500, 6000 };
        static int[] MinMaxInternalWidth { get; } = { 375, 525 };
        static int[] MinMaxPitch { get; } = { 70, 90 };
        static int[] MinMaxStepSpacing { get; } = { 250, 300 };

        public static bool CheckInputCompliance(int[] userInput)
        {
            bool result = ComplianceCheck
                (GenerateCompareData(MinMaxVerticalHeight, MinMaxInternalWidth, MinMaxPitch), userInput);

            return result;
        }

        public override string ToString()
        {
            return String.Format("Check user input to Rung Ladder Compliance Data AS1657");
        }
    }
}

// Future Implementaion
// Data to be set by reading external config file/DB
