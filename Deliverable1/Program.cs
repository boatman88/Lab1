using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {   //Ask the user to input a measurement type. Assume you will get valid inputs.
            bool tryAgain = true;
            do
            {
                Console.WriteLine("Please type the unit you would like to convert from the following - fidget spinners, meme, foot, or inch?");
                string measurementInput = Console.ReadLine();

                //Ask the user for an amount. Assume valid inputs (such as the user won’t enter a string when a number is called for).
                Console.WriteLine("Please enter the value of the measurement you would like to convert.");
                //one line
                decimal unit = decimal.Parse(Console.ReadLine());

                /* ● Convert the entered number to the correct new unit - 
                    ○ 1 pt: inch value is converted properly to fidget spinners value
                    ○ 1 pt: fidget spinners value is converted properly to inch value
                    ○ 1 pt: foot value is converted properly to meme value
                    ○ 1 pt: meme value is converted properly to foot */

                //1 inch      3.5 fidget spinners
                //1 foot      5 memes

                if (measurementInput == "inch")
                {
                    decimal resultInFidgetSpinners = unit * (decimal)3.5;
                    Console.WriteLine(resultInFidgetSpinners + " fidget spinners");

                }
                else if (measurementInput == "fidget spinners")
                {
                    decimal resultInInches = unit / (decimal)3.5;
                    Console.WriteLine(resultInInches + " inch");

                }
                else if (measurementInput == "foot")
                {
                    decimal resultInMemes = unit * (decimal)5;
                    Console.WriteLine(resultInMemes + " meme");

                }
                else if (measurementInput == "meme")
                {
                    decimal resultInFoot = unit / (decimal)5;
                    Console.WriteLine(resultInFoot + " foot");
                }
                /*● Ask the user if they wish to do another calculation
                ○ 1 pt: If the user responds yes, loop back to the top of the program
                ○ 1 pt: If the user responds with anything else, end the program*/
                Console.WriteLine("Do you wish to do another calculation?");
                string repeatCalculationInput = (Console.ReadLine());
                if (repeatCalculationInput == "yes")
                {
                    tryAgain = true;
                } else
                {
                    tryAgain = false;

                }
            } while (tryAgain == true);

        }
    }
}