using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBD_LadderGenerator
{
    internal class InputComplianceCheck : ILadderComplianceData
    {

        public static int[] MinMaxVerticalHeight { get; private set; }
        public static int[] MinMaxInternalWidth { get; private set; }
        public static int[] MinMaxPitch { get; private set; }
        public static int[] MinMaxStepSpacing { get; private set; }


        public static bool RunComplianceCheck(string ladderType, List<int> userInput)
        {
            AssignCompData(ladderType);

            return ComplianceCheck(userInput);
        }

        private static void AssignCompData(string ladderType)
        {
            switch (ladderType)
            {
                case "rungLadder":
                    AssignRungLadderData();
                    break;
                case "stepLadder":
                    AssignStepLadderData();
                    break;
                case "stairCase":
                    AssignStairCaseData();
                    break;
                default: throw new ArgumentException("No ladder type given");
            }
        }

        private static bool ComplianceCheck(List<int> userInput)
        {
            int[][] compData = new int[][] { MinMaxVerticalHeight, MinMaxInternalWidth, MinMaxPitch };

            bool result = false;

            int i = 0;

            foreach (var input in userInput)
            {
                if (input >= compData[i][0] && input <= compData[i][1])
                {
                    result = true;
                    i++;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private static void AssignRungLadderData()
        {
            MinMaxVerticalHeight = new int[] { 500, 6000 };
            MinMaxInternalWidth = new int[] { 375, 525 };
            MinMaxPitch = new int[] { 70, 90 };
            MinMaxStepSpacing = new int[] { 250, 300 };
        }

        private static void AssignStepLadderData()
        {
            MinMaxVerticalHeight = new int[] { 600, 6000 };
            MinMaxInternalWidth = new int[] { 450, 750 };
            MinMaxPitch = new int[] { 60, 70 };
            MinMaxStepSpacing = new int[] { 200, 300 };
        }

        private static void AssignStairCaseData()
        {
            MinMaxVerticalHeight = new int[] { 500, 4000 };
            MinMaxInternalWidth = new int[] { 600 };
            MinMaxPitch = new int[] { 20, 45 };
            MinMaxStepSpacing = new int[] { 200, 300 };
        }
    }
}
