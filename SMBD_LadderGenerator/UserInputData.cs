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
    internal class UserInputData
    {
        public static string JobNumber { get; set; }
        public static string InputLadderType { get; set; }
        public static int InputLadderVerticalHeight { get; set; }
        public static int InputLadderWidth { get; set; }
        public static int InputLadderPitch { get; set; }

        Dictionary<string, object> inputData = new Dictionary<string, object>()
        {
            {"Job Number", JobNumber },
            {"Ladder Type", InputLadderType},
            {"Vertical Height", InputLadderVerticalHeight},
            {"Ladder Width", InputLadderWidth},
            {"Ladder Pitch", InputLadderPitch},
        };

        public void dataCheck()
        {
            Console.WriteLine(inputData);
        }
    }
}

