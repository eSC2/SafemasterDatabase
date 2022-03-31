using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBD_LadderGenerator
{
    /// <summary>
    /// Checking input data against compliance data
    /// </summary>
    internal struct InputComplianceCheck : ILadderComplianceData
    {
        static int[][] ComplianceData = new int[4][];

        /// <summary>
        /// Running Compliance Check on input data for specific ladder type
        /// </summary>
        /// <param name="ladderType">Ladder type to be checked</param>
        /// <param name="userInput">User input data to be checked</param>
        /// <returns></returns>
        public static bool RunComplianceCheck(string ladderType, List<int> userInput)
        {
            AssignCompData(ladderType);

            return ComplianceCheck(userInput, ComplianceData);
        }

        // Running assign compliance data according to ladder type given
        private static void AssignCompData(string ladderType)
        {
            switch (ladderType)
            {
                case "rungLadder":
                    ComplianceData = LadderComplianceData.AssignRungLadderData();
                    break;
                case "stepLadder":
                    ComplianceData = LadderComplianceData.AssignStepLadderData();
                    break;
                case "stairCase":
                    ComplianceData = LadderComplianceData.AssignStairCaseData();
                    break;
                default: throw new ArgumentException("No ladder type given");
            }
        }

        // Running compliance check with given user input data against compliance data
        private static bool ComplianceCheck(List<int> userInput, int[][] compData)
        {

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
    }
}
