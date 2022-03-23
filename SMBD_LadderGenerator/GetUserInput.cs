using System;
using System.Collections;
using System.Collections.Generic;

// 1. Get user input.
// 1a. User choose which ladder to generate (rung, step, stair)
// 1b. User input required information (Job no, Vertical Height, Ladder Pitch, Ladder Width)
// 1c. Check whether input data meets AS1657 requirements for requested ladder
// 1d. Create temporary ladder object with given info and return it for futher processing

namespace SMBD_LadderGenerator
{
    internal class GetUserInput
    {

        // Test Values
        static string JobNumber = "SMxxxxx";
        static string InputLadderType = "Rung Ladder";
        static int InputLadderVerticalHeight = 1000;
        static int InputLadderWidth = 535;
        static int InputLadderPitch = 70;

        public static int[] AssignUserInput()
        {
            int[] inputDataArr = new int[]
            {
                InputLadderVerticalHeight, InputLadderWidth, InputLadderPitch,
            };

            return inputDataArr;
        }
    }
}


