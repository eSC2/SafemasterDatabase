using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBD_LadderGenerator
{
    internal interface ILadderComplianceData
    {
        static int[] MinMaxVerticalHeight { get; }
        static int[] MinMaxPitch { get; }
        static int[] MinMaxInternalWidth { get; }
        static int[] MinMaxStepSpacing { get; }

        bool CheckCompliance(int[] userInput);
    }
}
