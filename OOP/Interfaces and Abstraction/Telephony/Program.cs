using System;

namespace Telephony
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] url = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    string number = numbers[i];
                    if (number.Length == 7)
                    {
                        Console.WriteLine(stationaryPhone.Call(number));
                    }
                    else if (number.Length == 10)
                    {
                        Console.WriteLine(smartphone.Call(number));
                    }

                }
                catch (InvalitdNumExeption ex)
                {
                    Console.WriteLine(ex.Message);                    
                }

            }

            for (int i = 0; i < url.Length; i++)            
            {
                string currentUrl = url[i];
                try
                {
                    Console.WriteLine(smartphone.Browse(currentUrl));
                }
                catch (InvalidUrlExeption ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

        }
    }
}
