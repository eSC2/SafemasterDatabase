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
        int MaxVerticalHeight { get; }
        int MinVerticalHeight { get; }
        int MaxSlope { get; }
        int MinSlope { get; }
        //int MaxInternalWidth { get; }
        int MinInternalWidth { get; }
        int MaxStepSpacing { get; }
        int MinStepSpacing { get; }
    }
}
