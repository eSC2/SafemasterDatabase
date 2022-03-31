using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBD_LadderGenerator
{

    internal class LadderSystem : IEnumerable<int>
    {
        int _JobNumber { get; set; }
        int _LadderVerticalHeight { get; set; }
        int _LadderIntervalWidth { get; set; }
        int _LadderPitch { get; set; }
        int _LadderBodyLength { get; set; }
        int _NumberOfSteps { get; set; }
        int _StepDistance { get; set; }

        public LadderSystem(int ladderVH, int ladderW, int ladderP, int jobNumber)
        {
            this._LadderVerticalHeight = ladderVH;
            this._LadderIntervalWidth = ladderW;
            this._LadderPitch = ladderP;
            this._JobNumber = jobNumber;
        }

        public int LadderBodyLength
        {
            get { return _LadderBodyLength; }
            protected set { _LadderBodyLength = value; }
        }

        public int NumberOfSteps
        {
            get { return _NumberOfSteps; }
            protected set { _NumberOfSteps = value; }
        }

        public int StepDistance
        {
            get { return _StepDistance; }
            protected set { _StepDistance = value; }
        }

        public IEnumerator<int> GetEnumerator()
        {
            int[] returnArr = new int[] { _JobNumber, _LadderVerticalHeight, _LadderIntervalWidth, _LadderPitch, _LadderBodyLength, _NumberOfSteps, _StepDistance };

            foreach (var i in returnArr)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
