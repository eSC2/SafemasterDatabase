using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBD_LadderGenerator
{
    internal interface ILadderComplianceData
    {

        // MaxInternalWidth not included as Stair Case does not implement this interface
        static int[] MinMaxVerticalHeight { get; }
        static int[] MinMaxSlope { get; }
        static int[] MinMaxInternalWidth { get; }
        static int[] MinMaxStepSpacing { get; }

    }
}
