using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UppgiftTelefon
{
    class GSM
    {
        internal static GSM Iphone4S
        {
            get
            {
                return new GSM("Iphone4S", "Apple", 4500);
            }
        }

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int? Price { get; set; }
        public string Owner { get; set; }

        public GSM()
        {

        }

        public GSM(string model, string manufacturer, int? price, string owner = null, Battery battery = null, Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery1 = battery;
            this.Display1 = display;

        }
        Battery Battery1 = new Battery();
        Display Display1 = new Display();

        internal string DisplayAllInfo()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append($"Model : {this.Model}\nManufacturer : {this.Manufacturer}\n");
            if (Price != null)
            {
                sb.Append($"Price : {this.Price}\n");
            }
            else
            {
                sb.Append($"Price : N/S\n");
            }
            if (Owner != null)
            {
                sb.Append($"Owner : {this.Owner}\n");
            }
            else
            {
                sb.Append($"Owner : N/S\n");
            }
            if (Battery1 != null)
            {
                sb.Append($"Battery : model {Battery1.BatteryModel}, type {Battery1.BType}, Hours Idle {Battery1.BatteryHoursIdle}, Hours talk {Battery1.BatteryHoursTalk}\n");

            }
            else
            {
                sb.Append($"Batterymodel : N/S\n");
            }
            if (Display1 != null)
            {
                sb.Append($"Display : Size {Display1.DisplaySize}, Amount of colors {Display1.DisplayNumOfColors}\n");

            }
            else
            {
                sb.Append($"Display : N/S\n");
            }

            return sb.ToString();

        }
        List<Call> callhistory = new List<Call>
        {
            new Call { StartTime = new DateTime(2020, 11, 20, 15, 58, 57), DialedPhoneNumber = 0702286984, TimespanSeconds = 2.5F },
            new Call { StartTime = new DateTime(2020, 11, 21, 11, 38, 15), DialedPhoneNumber = 0702298745, TimespanSeconds = 7.3F },
            new Call { StartTime = new DateTime(2020, 11, 22, 12, 03, 52), DialedPhoneNumber = 0703636547, TimespanSeconds = 9.2F },
            new Call { StartTime = new DateTime(2020, 11, 23, 09, 18, 03), DialedPhoneNumber = 0785687456, TimespanSeconds = 4.7F },
        };


        internal void ListCalls()
        {
            callhistory = callhistory.OrderBy(x => x.TimespanSeconds).ToList();
            int count3 = 0;
            foreach (var calls in callhistory)
            {
                Console.WriteLine($" {count3 + 1} Phone# {calls.DialedPhoneNumber}, Start time : {calls.StartTime}, Timespan: {calls.TimespanSeconds} ");
                count3++;

            }
            Console.WriteLine("\nPress enter for call menu");
            Console.ReadLine();

        }
        internal void AddingCalls()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("New call");
                Console.WriteLine("Phonenumber: ");
                int phonenumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Duration in seconds : ");
                float seconds = float.Parse(Console.ReadLine());
                callhistory.Add(new Call { StartTime = DateTime.Now, DialedPhoneNumber = phonenumber, TimespanSeconds = seconds });
                Console.WriteLine("Call is now addes, press enter for call menu");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input, press enter to try again");
                Console.WriteLine("Correct format example = Phonenumber : 0702286984 Duration in seconds = 2,5 ");
                Console.ReadLine();
                AddingCalls();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Wrong input, press enter to try again");
                Console.WriteLine("Correct format example = Phonenumber : 0702286984 Duration in seconds = 2,5 ");
                Console.ReadLine();
                AddingCalls();
            }

        }
        internal void DeletingCalls()
        {
            try
            {
                Console.Clear();
                callhistory = callhistory.OrderBy(x => x.TimespanSeconds).ToList();
                int count = 0;
                foreach (var calls in callhistory)
                {
                    Console.WriteLine($" {count + 1} Phone# {calls.DialedPhoneNumber}, Start time : {calls.StartTime}, Timespan: {calls.TimespanSeconds} ");
                    count++;
                }

                Console.WriteLine("Which call do you want to remove?");
                int choice = int.Parse(Console.ReadLine());

                for (int i = 0; i < callhistory.Count; i++)
                {
                    if (choice == i + 1)
                    {
                        callhistory.RemoveAt(i);
                        Console.WriteLine($"The call {i + 1} is now removed");
                        Console.WriteLine($"Press enter for call menu");
                    }
                }
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("You can only choose a number, no other inputs allowed");
                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
                DeletingCalls();
            }

        }

        internal void ClearCallHistory()
        {
            Console.WriteLine("All calls in the call history will now be removed");

            callhistory.Clear();

            Console.ReadLine();
        }

        internal void CalculatePriceCalls()
        {
            callhistory = callhistory.OrderBy(x => x.TimespanSeconds).ToList();
            float totalPrice = 0;
            int count = 0;
            foreach (var call in callhistory)
            {
                float price = 0.37F * call.TimespanSeconds;
                count++;
                Console.WriteLine($"Price for call number {count} = {price} kr : Duration in seconds {call.TimespanSeconds}");
                totalPrice += price;
            }
            Console.WriteLine($"Total price : {totalPrice} kr");
            Console.ReadLine();
        }
    }
}
