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
    internal class UserInputs
    {

        // Test Values - Rung Ladder
        static string InputLadderType = "rungLadder";
        static int JobNumber = 12345;
        static int InputLadderVerticalHeight = 1000;
        static int InputLadderWidth = 525;
        static int InputLadderPitch = 70;

        // Test Values - Step Ladder
        //static string InputLadderType = "stepLadder";
        //static int JobNumber = 12345;
        //static int InputLadderVerticalHeight = 1000;
        //static int InputLadderWidth = 600;
        //static int InputLadderPitch = 90;

        public static List<int> GetUserInput()
        {
            var input = AssignUserInput();

            var result = InputComplianceCheck.RunComplianceCheck(InputLadderType, input);

            if (result)
                input.Add(JobNumber);
            else
                input = null;

            return input;
        }

        private static List<int> AssignUserInput()
        {
            List<int> inputDataList = new List<int>
            {
                InputLadderVerticalHeight, InputLadderWidth, InputLadderPitch,
            };

            return inputDataList;
        }
    }
}


