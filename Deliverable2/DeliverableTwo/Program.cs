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

            Console.Write("Hello! What is your name?  ");
            user = Console.ReadLine();

            try
            {
                do //loop the whole experience if the user enters Y/y. The default is N for no. 
                {
                    do
                    {
                        travelPan = new Travel();
                        travelPan.PrintHeader();
                        travelPan.DisplayActivity();

                        Console.Write("Hello {0}! What are you in the mood for?  ", user);
                        
                    } while (!travelPan.SetRecommendedActivity(Console.ReadLine().ToUpper()));/* Do while the user input is invalid
                        Sends uppercase user input. */

                    do
                    {
                        Console.Write("\n\n\nHow many persons are you joining you?  ");

                    } while (!travelPan.GetRecommendedTransport(Console.ReadLine()));/*Do while user input is invalid */
                                       
                    travelPan.PrintHeader();
                    Console.WriteLine("\n\n\n Thank you {0}, here's our recommendation:\n\n {1}", user, travelPan.ToString());

                    Console.Write("\n\n\nDo you want to continue?[N]:  ");

                } while (Console.ReadLine().ToLower() == "y"); 

                Console.WriteLine("\n\n\nGoodbye {0} and thanks for stopping by! Press Enter to close window.", user);
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
