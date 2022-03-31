using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBD_LadderGenerator
{
    internal class LadderComplianceData : ILadderComplianceData
    {
        static int[] MinMaxVerticalHeight { get; set; }
        static int[] MinMaxInternalWidth { get; set; }
        static int[] MinMaxPitch { get; set; }
        static int[] MinMaxStepSpacing { get; set; }

        // Rung ladder compliance data to AS1657
        public static int[][] AssignRungLadderData()
        {
            MinMaxVerticalHeight = new int[] { 500, 6000 };
            MinMaxInternalWidth = new int[] { 375, 525 };
            MinMaxPitch = new int[] { 70, 90 };
            MinMaxStepSpacing = new int[] { 250, 300 };

            int[][] compDataArr =  {MinMaxVerticalHeight, MinMaxInternalWidth, MinMaxPitch, MinMaxStepSpacing};

            return compDataArr;
        }


        // Step Ladder compliance data to AS1657
        public static int[][] AssignStepLadderData()
        {
            MinMaxVerticalHeight = new int[] { 600, 6000 };
            MinMaxInternalWidth = new int[] { 450, 750 };
            MinMaxPitch = new int[] { 60, 70 };
            MinMaxStepSpacing = new int[] { 200, 300 };

            int[][] compDataArr = { MinMaxVerticalHeight, MinMaxInternalWidth, MinMaxPitch, MinMaxStepSpacing };

            return compDataArr;
        }

        // Stair case compliance data to AS1657
        public static int[][] AssignStairCaseData()
        {
            MinMaxVerticalHeight = new int[] { 500, 4000 };
            MinMaxInternalWidth = new int[] { 600 };
            MinMaxPitch = new int[] { 20, 45 };
            MinMaxStepSpacing = new int[] { 200, 300 };

            int[][] compDataArr = { MinMaxVerticalHeight, MinMaxInternalWidth, MinMaxPitch, MinMaxStepSpacing };

            return compDataArr;
        }
    }
}
