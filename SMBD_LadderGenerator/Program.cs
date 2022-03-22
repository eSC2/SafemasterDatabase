using System;

namespace SMBD_LadderGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Start load user interface
            UserInterface();

            // Load functions
            GenerateLadder();
            GetDatabase();
            GenerateAnalytics();
        }
    }
}
