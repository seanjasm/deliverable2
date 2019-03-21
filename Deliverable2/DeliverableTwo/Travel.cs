using System;

namespace DeliverableTwo
{
    class Travel
    {        
        private string userRecommendation;
        //Used constant variable to make menu option more scalable e.g changing the following constants here to 1, 2, 3, 4
        //Respectively will change the menu option and the error message suggestion as well. Go ahead, give it a try!             
        private const string activity_action = "A";
        private const string activity_chill = "C";
        private const string activity_danger = "D";
        private const string activity_good_food = "G";


        public Travel()
        {
            userRecommendation = "If you want an activity for "; 
        }
        
        public void PrintHeader()
        {
            Console.Clear();
            Console.WriteLine("                         Welcome to Travel With Mates Dot Com\n\n\n\n\n");
        }
      
        //Display the list of activities as a numerical menu
        public void DisplayActivity()
        {
            Console.WriteLine("Here's our recommended activity\n\n");
            Console.WriteLine("  {0}.....Action\n", activity_action);
            Console.WriteLine("  {0}.....Chill\n", activity_chill);
            Console.WriteLine("  {0}.....Danger\n", activity_danger);
            Console.WriteLine("  {0}.....Good Food\n\n", activity_good_food);
        }

        
        //Fuction accepts user string and returns true if there is a match, otherwise false
        public bool SetRecommendedActivity(string atype)
        {          

            if (activity_action == atype)
            {
                userRecommendation += "action, go stock car racing.";
            }
            else if (activity_chill == atype)
            {
                userRecommendation += "chill, go hiking.";
            }
            else if (activity_danger == atype)
            {
                userRecommendation += "danger, go skydiving.";
            }
            else if (activity_good_food == atype)
            {
                userRecommendation += "good food, go to Taco Bell.";
            }
            else
            {
               DisplayInvalidMessage();
                return false;
            }

            return true;
        }

        /*Fuction accepts user string and returns true if the string is an integer greater than and equal zero, 
         *  otherwise false.
             */
        public bool GetRecommendedTransport(string amountOfCompanion)
        {
            int amount = 0;

            try
            {
                //checks if amountOfcompanion is an integer and if so, assign the value to amount
                //if not print an error message and return false
                if (!Int32.TryParse(amountOfCompanion, out amount))
                {
                    DisplayInvalidCompanionAmount();
                    return false;
                }

                /*formated the recommendation to have the correct subject verb agreement based on the number of persons 
                        joining the user */
                

                //checks if amount greater than or equal to zero
                //if not display an error message and return false
                if (amount >= 0)
                {     
                    //Checks the amount, if it is greater than 1 and displayed the correspoding subject verb agreement
                    //e.g if there is 3 persons, the plural form "persons", "are" are used instead of "person", and "is" for 1 and zero
                    userRecommendation += string.Format("\n If {0} {1} ", amount, amount > 1 ? "persons" : "person");
                    userRecommendation += string.Format("{0} joining you, you should travel in ", amount > 1 ? "are" : "is");

                    if (amount == 0)
                    {
                        userRecommendation += "sneakers.";
                    }
                    else if (amount < 5)
                    {
                        userRecommendation += "a sedan.";
                    }
                    else if (amount <= 10)
                    {
                        userRecommendation += "a Volkswagen bus.";
                    }
                    else if (amount > 10)
                    {
                        userRecommendation += "an airplane.";
                    }
                }
                else
                {
                    DisplayInvalidCompanionAmount();
                    return false;
                }

                return true;
            }
            catch {
                DisplayInvalidCompanionAmount();
                return false;
            }
            
        }
        
        //Display error message if user enetered invalid activity option and recommends a valid input
        private void DisplayInvalidMessage()
        {
            string acceptedValues = string.Format("{0}, {1}, {2}, or {3}", activity_action, activity_chill, activity_danger, activity_good_food);

            Console.Write("\n\n\n\a Your selection was invalid.\n Please enter {0}. Press Enter to continue.", acceptedValues);
            Console.ReadLine();
        }

        //Display error message if number of person joining is invalid
        private void DisplayInvalidCompanionAmount()
        {
            Console.Write("\n\n\n\a Your input was not understood. Enter a valid number.");
        }

        //overrided to return the recommendation
        public override string ToString()
        {
            return userRecommendation;
        }

    }
}
