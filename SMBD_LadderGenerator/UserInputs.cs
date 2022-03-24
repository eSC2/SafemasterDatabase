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

        // Test Values
        static string JobNumber = "SMxxxxx";
        static string InputLadderType = "Rung Ladder";
        static int InputLadderVerticalHeight = 1000;
        static int InputLadderWidth = 525;
        static int InputLadderPitch = 70;

        static bool compCheckResult = false;

        public static int[] GetUserInput()
        {
            var input = AssignUserInput();

            switch (InputLadderType)
            {
                case "Rung Ladder":
                    compCheckResult = RungLadderCheck.CheckInputCompliance(input);
                    break;

                case "Step Ladder":
                    compCheckResult = StepLadderCheck.CheckInputCompliance(input);
                    break;

                case "Stair Case":
                    break;

                    // Need proper error handling
                default: throw new ArgumentException("Ladder Type input missing");
            }


            if (compCheckResult)
                return input;
            else
                return null;
        }

        private static int[] AssignUserInput()
        {
            int[] inputDataArr = new int[]
            {
                InputLadderVerticalHeight, InputLadderWidth, InputLadderPitch,
            };

            return inputDataArr;
        }
    }
}


