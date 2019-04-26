using System;

namespace DeliverableTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = "";
            Travel travelPan = new Travel(); ; 

            travelPan.PrintHeader();

            user = travelPan.GetUserInput("Hello! What is your name?  ");

            try
            {
                do //loop the whole experience if the user enters Y/y. The default is N for no. 
                {
                    do
                    {
                        travelPan = new Travel();
                        travelPan.PrintHeader();
                        travelPan.DisplayActivity();

                        
                    } while (!travelPan.SetRecommendedActivity(travelPan.GetUserInput($"Hello {user}! What are " +
                    $"you in the mood for? ")));/* Do while the user input is invalid
                        Sends uppercase user input. */

                    travelPan.GetRecommendedTransport(travelPan.ParseUserInputAsInteger("How many persons are" +
                    " you joining you ? "));


                    travelPan.PrintHeader();
                    Console.WriteLine($"\n\n\n Thank you {user}, here's our recommendation:\n\n {travelPan.ToString()}");

                    Console.Write("\n\n\n");

                } while (travelPan.GetUserInput("Do you want to continue?[N]: ").StartsWith("y", StringComparison.OrdinalIgnoreCase)); 

                Console.WriteLine($"\n\n\nGoodbye {user} and thanks for stopping by! Press Enter to close window.");
                Console.ReadLine();

            }
            catch//Catches all unforeseen errors
            {
                Console.WriteLine("\n\n\nThere seem to be an error! Press ENTER to close window.");
                Console.ReadLine();
            }
        }


    }
}
