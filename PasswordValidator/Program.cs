using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Password Validator *****");
            Console.WriteLine("Password must contain 1 Capital Letter, 1 number, 1 smallcase letter and length must be more than 6 characters");

            Console.WriteLine("Please enter the password: ");
            var password = Console.ReadLine();

            var isValid = validator(password) ? "Successful" : "Unsuccessful";

            Console.WriteLine($"Password validation {isValid}!");
            Console.ReadKey();
        }

        public static bool validator(string password)
        {
            return lengthChecker(password) && 
                    hasLetterOrDigit(password) &&
                    hasUpper(password) && 
                    hasLower(password) && 
                    hasNumber(password);
        }

        public static bool hasUpper(string password)
        {
            return password.Any(c => char.IsUpper(c));
        }
        
        public static bool hasLower(string password)
        {
            return password.Any(c => char.IsLower(c));
        }

        public static bool hasNumber(string password)
        {
            return password.Any(c => char.IsNumber(c));
        }

        public static bool lengthChecker(string password)
        {
            return password.Length >= 6;
        }

        public static bool hasLetterOrDigit(string password)
        {
            return password.All(c => char.IsLetterOrDigit(c));
        }
    }
}
