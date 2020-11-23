using System;
using System.Collections.Generic;
using System.Text;

namespace UppgiftTelefon
{
    // Create an array of few instances of the GSM class
    // Display the information about the GSM in the array
    // Display the information about the static property IPhone4S
    class GSMTest
    {
        private static GSM[] telephones = new GSM[5];
        internal static void Telephones()
        {
            telephones[0] = new GSM("3310", "Nokia", 300, "Gertrud Nilsson", new Battery(Battery.BatteryType.Li_lon, "85KLI", 10.5,2.5), new Display("170X40", 1000));
            telephones[1] = new GSM("3330", "Nokia", 350, "Agda Persson", new Battery(Battery.BatteryType.NiCd, "UIR25", 11.3, 3.1), new Display("170X40", 1000));
            telephones[2] = new GSM("Galaxy A42", "Samsung", 12000, "Anton Friberg", new Battery(Battery.BatteryType.NiCd, "GAL42i", 34, 21), new Display("720X1600 HD+", 1000));


            Console.WriteLine(telephones[0].DisplayAllInfo());
            Console.WriteLine(telephones[1].DisplayAllInfo());
            Console.WriteLine(telephones[2].DisplayAllInfo());
            Console.WriteLine(GSM.Iphone4S.DisplayAllInfo());

            Console.WriteLine("\nPress enter for main menu");

            Console.ReadLine();

            
        }

       



         



    }
}
