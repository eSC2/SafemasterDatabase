using System;

namespace SMBD_LadderGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userInput = UserInputs.GetUserInput();

            foreach (var input in userInput)
            {
                Console.WriteLine(input);
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
