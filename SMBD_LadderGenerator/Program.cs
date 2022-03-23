using System;

namespace SMBD_LadderGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var temp = GetUserInput.AssignUserInput();

            RungLadderComplianceData RungComp = new RungLadderComplianceData();

            RungComp.CheckCompliance(temp);


            // Start load user interface
            //UserInterface();

            // Load functions
            //GetUserInput();
            //GenerateLadder();
            //GetDatabase();
            //GenerateAnalytics();
        }
    }
}
