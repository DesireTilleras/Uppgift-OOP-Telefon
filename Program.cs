using System;

namespace UppgiftTelefon
{
    class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            program.Menu();
    
        }

        protected void Menu()
        {
            try
            {
                GSMCallHistoryTest callhistoryTest = new GSMCallHistoryTest();
                int userInput;
                do
                {
                    userInput = DisplayMenu2();
                    Console.Clear();
                    switch (userInput)
                    {
                        case 1:
                            GSMTest.Telephones();
                            break;
                        case 2:
                            callhistoryTest.MainMenuCallTest();
                            break;

                        default:
                            break;
                    }
                    if (userInput >2)
                    {
                        Console.WriteLine("Wrong input, you can only chose between number 1 or 2, no other inputs allowed");
                        Console.WriteLine("Press enter to try again");
                        Console.ReadLine();
                        Menu();
                    }

                } while (userInput != 3);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input, you can only chose between number 1 or 2, no other inputs allowed");
                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
                Menu();
            }
     

        }
        protected int DisplayMenu2()
        {
            Console.Clear();
            Console.WriteLine("1. GSM information");
            Console.WriteLine("2. Go to Call Menu");
            Console.Write("Make a choice : ");
            var result = int.Parse(Console.ReadLine());
            return result;

        }
    }
}
