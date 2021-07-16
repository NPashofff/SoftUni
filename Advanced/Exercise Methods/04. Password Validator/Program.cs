using System;
using System.Dynamic;
using System.Linq;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValid = true;

            if (PasswordLenght(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            if (PasswodDogitAndLettersOnly(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }

            if (PAsswordDigitCounter(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }

        }

        private static bool PAsswordDigitCounter(string password)
        {
            int counter = 0;
            foreach (var VARIABLE in password)
            {
                if (char.IsDigit(VARIABLE))
                {
                    counter++;
                }

                if (counter == 2)
                {
                    return false;
                }
            }
            
            return true;
        }

        private static bool PasswodDogitAndLettersOnly(string password)
        {
            foreach (var VARIABLE in password)
            {
                if (!(char.IsLetterOrDigit(VARIABLE)))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool PasswordLenght(string password)
        {
            int counter = 0;
            foreach (var VARIABLE in password)
            {
                counter++;
            }

            if (counter >= 6 && counter <= 10)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
