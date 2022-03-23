using System;
using System.Collections.Generic;

namespace SMBD_LadderGenerator
{
    internal class RungLadderComplianceData : ILadderComplianceData
    {
        static int[] MinMaxVerticalHeight { get; } = { 500, 6000 };
        static int[] MinMaxPitch { get; } = { 70, 90 };
        static int[] MinMaxInternalWidth { get; } = { 375, 525 };
        static int[] MinMaxStepSpacing { get; } = { 250, 300 };

        private static int[][] CompData = new int[][]
        {
            MinMaxVerticalHeight, MinMaxPitch, MinMaxInternalWidth
        };

        public override string ToString()
        {
            return String.Format("Rung Ladder Compliance Data to AS1657");
        }

        public bool CheckCompliance(int[] userInput)
        {
            bool result = false;

            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] > CompData[i][i] && userInput[i] < CompData[i][i + 1])
                    result = true;
                else
                    result = false;
            }

            //foreach (int[] i in CompData)
            //{
            //    foreach (int j in i)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}

            return result;
        }
    }
}

// Future Implementaion
// Data to be set by reading external config file/DB
