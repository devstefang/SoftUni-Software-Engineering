using System;
using System.Linq;

namespace _04.Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            
            CheckCharacters(password);
            CheckDigitCount(password);
            CheckDigitsAndLetters(password);
            bool isValid = CheckCharacters(password) && CheckDigitCount(password) && CheckDigitsAndLetters(password);
                if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!CheckCharacters(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!CheckDigitCount(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
                if (!CheckDigitsAndLetters(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
            }
           
             

        }
        private static bool CheckCharacters(string password)
        {
            bool isEnoughCharacters = true;
            if (password.Length < 6 || password.Length > 10)
            {
                
                isEnoughCharacters = false;
                return isEnoughCharacters;
            }
           
            return isEnoughCharacters;
        }
        private static bool CheckDigitsAndLetters(string password)
        {
            bool isContainingDigitsAndLetters = true;
            
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    isContainingDigitsAndLetters = false;
                    return isContainingDigitsAndLetters;
                }
            }

            return isContainingDigitsAndLetters;
        }
        private static bool CheckDigitCount(string password)
        {
            bool isWithTwoDigits = true;
            int count = 0;
            foreach (char c in password)
            {
                 
                if (char.IsDigit(c))
                {
                    count++;
                }
                
            }
            if (count < 2)
            {
                isWithTwoDigits = false;
                return isWithTwoDigits;
            }
            return isWithTwoDigits;
        }

    }
}
