using System;

namespace SMBD_LadderGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testLadder = new StairCaseComplianceData();

            var props = testLadder.GetType().GetProperties();

            foreach (var obj in props)
            {
                Console.WriteLine(obj.ToString());
            }

            // Start load user interface
            //UserInterface();

            // Load functions
            //GenerateLadder();
            //GetDatabase();
            //GenerateAnalytics();
        }
    }
}
