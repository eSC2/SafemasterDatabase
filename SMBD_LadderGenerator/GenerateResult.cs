using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2. Generate result.
// 2a. Calculate result with given data and create ladder object
// 2b. Calculate materials required for given ladder
// 2c. Return result data for further processing

namespace SMBD_LadderGenerator
{
    internal class GenerateResult
    {
        // Assuming the input data passed compliance test and ladder type confirmed
        // Calculate according to ladder type
        public void CalculateResult(LadderType ladderType)
        {
            switch (ladderType.InputLadderType)
            {
                case "rungLadder":
                    break;

                case "stepLadder":
                    break;

                case "stairCase":
                    break;

                default:
                    break;
            }
        }
    }
}
