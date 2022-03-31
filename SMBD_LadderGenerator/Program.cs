using System;

namespace SMBD_LadderGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = UserInputs.GetUserInput();

            if (input == null)
            {
                Console.WriteLine("Non-compliant input");
            }
            else
            {
                var rungLadder = new RungLadder(input[0], input[1], input[2], input[3]);

                foreach (var e in rungLadder)
                {
                    Console.WriteLine(e);
                }
            }

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
