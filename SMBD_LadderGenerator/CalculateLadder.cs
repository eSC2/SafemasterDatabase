using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBD_LadderGenerator
{
    internal interface CalculateLadder
    {
        int VerticalHeight { get; set; }
        int Length { get; set; }
        int Width { get; set; }
        int Pitch { get; set; }

        public int CalcLength();
        public int CalcStepSpacing();
        public int CalcStepQty();
    }
}
