using System;
using System.Collections.Generic;
using System.Text;

namespace UppgiftTelefon
//Create an instance of the GSM class			
//Add a few calls
//Display the info about the calls
//Assuming the price per minute is 0,37			
//Calculate and print the total price of the calls in the history
//Remove the longest call from the history and calculate the total price again
//Finally clear the call history and print it			
{
    class GSMCallHistoryTest
    {
        internal void MainMenuCallTest()
        {
            try
            {
                GSM gsm = new GSM();
                int userInput;

                do
                {
                    userInput = DisplayMenu();
                    Console.Clear();
                    switch (userInput)
                    {
                        case 1:
                            gsm.AddingCalls();
                            break;
                        case 2:
                            gsm.DeletingCalls();
                            break;
                        case 3:
                            gsm.ListCalls();
                            break;
                        case 4:
                            gsm.ClearCallHistory();
                            break;
                        case 5:
                            gsm.CalculatePriceCalls();
                            break;
                        default:
                            break;
                    }
                    if (userInput > 6)
                    {
                        Console.WriteLine("Wrong input, you can only chose between number 1 or 2, no other inputs allowed");
                        Console.WriteLine("Press enter to try again");
                        Console.ReadLine();
                        MainMenuCallTest();
                    }

                } while (userInput != 6);
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Wrong input, you can only chose between the numbers 1-6, no other inputs allowed");
                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
                MainMenuCallTest();
            }
        }
        internal int DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add a call");
            Console.WriteLine("2. Delete a call");
            Console.WriteLine("3. List of calls");
            Console.WriteLine("4. Clear call history");
            Console.WriteLine("5. Total price for all calls");
            Console.WriteLine("6. Go back to main menu");
            Console.Write("Make a choice : ");

            var result = int.Parse(Console.ReadLine());
            return result;

        }





    }
}
