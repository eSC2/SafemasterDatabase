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
                foreach (var r in input)
                {
                    Console.WriteLine(r);
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
