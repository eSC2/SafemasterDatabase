using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBD_LadderGenerator
{
    internal class InputComplianceCheck
    {
        private protected static bool ComplianceCheck(int[] minMaxVHeight, int[] minMaxIntWidth, int[] minMaxP, List<int> userInput)
        {
            int[][] compData = new int[][] { minMaxVHeight, minMaxIntWidth, minMaxP };

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
            Console.WriteLine(result);
            return result;
        }

        //private protected static int[][] GenerateCompareData
        //    (int[] minMaxVHeight, int[] minMaxIntWidth, int[] minMaxP)
        //{
        //    int[][] CompData = new int[][] { minMaxVHeight, minMaxIntWidth, minMaxP };

        //    return CompData;
        //}

        //private protected static bool ComplianceCheck(int[][] compData, int[] userInput)
        //{
        //    bool result = false;

        //    int i = 0;

        //    foreach (var input in userInput)
        //    {
        //        if (input >= compData[i][0] && input <= compData[i][1])
        //        {
        //            result = true;
        //            i++;
        //        }
        //        else
        //        {
        //            result = false;
        //            break;
        //        }
        //    }
        //    return result;
        //}
    }
}
