using System;

namespace SMBD_LadderGenerator
{

    /// <summary>
    /// Collection of functions for ladder calculation
    /// </summary>
    internal struct LadderCalcFx
    {

        /// <summary>
        /// Calculates the ladder body length based on given ladder pitch and vertical height
        /// </summary>
        /// <param name="degrees">Ladder pitch</param>
        /// <param name="verticalHeight">Vertical height</param>
        /// <returns>The length of ladder body to ladder pitch</returns>
        public static int BodyLength(int degrees, int verticalHeight)
        {
            // Convert degrees to radian
            double rad = degrees * (Math.PI / 180.0);

            // Returns length of ladder body
            return Convert.ToInt16(verticalHeight / Math.Sin(rad));
        }

        /// <summary>
        /// Calculates the number of steps/rungs
        /// </summary>
        /// <param name="baseLength">Ladder base length (rung ladder) / Vertical height (step ladder & stair case)</param>
        /// <param name="maxSpacing">Maximum allowable step spacing to respective ladder types in accordance to Compliance Standard</param>
        /// <returns>Number of steps/rungs</returns>
        public static int NumOfSteps(int bodyLength, int maxSpacing)
        {
            // Returns number of steps
            return Convert.ToInt16(Math.Ceiling((double)bodyLength / (double)maxSpacing));
        }

        /// <summary>
        /// Calculates the spacing between steps/rungs
        /// </summary>
        /// <param name="baseLength">Ladder base length (rung ladder) / Vertical height (step ladder & stair case)</param>
        /// <param name="stepQuantity">Number of steps/rungs</param>
        /// <returns>Spacing between steps/rungs</returns>
        public static int StepDistance(int baseLength, int stepQuantity)
        {
            // Returns spacing between steps
            return baseLength / stepQuantity;
        }
    }
}
