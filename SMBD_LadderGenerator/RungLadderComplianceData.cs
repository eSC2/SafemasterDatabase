using System;
using System.Collections.Generic;

namespace SMBD_LadderGenerator
{
    internal class RungLadderComplianceData : ILadderComplianceData
    {

        // Wrong way to implement?
        public static int[] MinMaxVerticalHeight { get; private set; } = { 500, 6000 };
        public static int[] MinMaxSlope { get; private set; } = { 70, 90 };
        public static int[] MinMaxInternalWidth { get; private set; } = { 375, 525 };
        public static int[] MinMaxStepSpacing { get; private set; } = { 250, 300 };

        public static Dictionary<string, object> RungLadderComplianceCheck = new()
        {
            { "MinMaxVerticalHeight", MinMaxVerticalHeight },
            { "MinMaxInternalWidth", MinMaxInternalWidth },
            { "MinMaxSlope", MinMaxSlope },
        };

        public static void CheckContent()
        {
            foreach (var i in RungLadderComplianceCheck)
            {
                Console.WriteLine(i.Value.GetType().GetProperties());
            }
        }

        public override string ToString()
        {
            return String.Format("Rung Ladder Compliance Data to AS1657");
        }
    }
}

// Future Implementaion
// Data to be set by reading external config file/DB
