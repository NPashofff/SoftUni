using System;

namespace _01._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            double journeyCost = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            double saevdMoneyMonthly = journeyCost * 0.25;
            double saevdMoney = 0;

            for (int i = 1; i <= months; i++)
            {
                if (i % 4 == 0)
                {
                    saevdMoney += saevdMoney * 0.25;
                    saevdMoney += saevdMoneyMonthly;
                }
                else if (i % 2 == 0 || i == 1)
                {
                    saevdMoney += saevdMoneyMonthly;
                }
                else if (i % 2 != 0)
                {
                    saevdMoney -= saevdMoney * 0.16;
                    saevdMoney += saevdMoneyMonthly;
                }
            }
            

            if (saevdMoney >= journeyCost)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {saevdMoney - journeyCost:f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {Math.Abs(saevdMoney - journeyCost):f2}lv. more.");
            }
            
        }
    }
}
