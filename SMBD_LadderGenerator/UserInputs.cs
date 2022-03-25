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
        //static string InputLadderType = "rungLadder";
        //static int JobNumber = 12345;
        //static int InputLadderVerticalHeight = 1000;
        //static int InputLadderWidth = 525;
        //static int InputLadderPitch = 70;

        // Test Values - Step Ladder
        static string InputLadderType = "stepLadder";
        static int JobNumber = 12345;
        static int InputLadderVerticalHeight = 1000;
        static int InputLadderWidth = 600;
        static int InputLadderPitch = 90;

        static bool inputCheckResult = false;

        public static List<int> GetUserInput()
        {
            var input = AssignUserInput();

            switch (InputLadderType)
            {
                case "rungLadder":
                    inputCheckResult = RungLadderCheck.CheckInputCompliance(input);

                    if (inputCheckResult)
                        input.Add(JobNumber);
                    break;

                case "stepLadder":
                    inputCheckResult = StepLadderCheck.CheckInputCompliance(input);

                    if (inputCheckResult)
                        input.Add(JobNumber);
                    break;

                case "stairCase":
                    inputCheckResult = StairCaseCheck.CheckInputCompliance(input);

                    if (inputCheckResult)
                        input.Add(JobNumber);
                    break;

                    // Need proper error handling
                default: throw new ArgumentException("Ladder Type input missing");
            }

            return input;
            //if (inputCheckResult)
            //    return input;
            //else
            //    return null;
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


