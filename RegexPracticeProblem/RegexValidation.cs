using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPracticeProblem
{
    internal class RegexValidation
    {
        public static void FirstNameValidation()
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] inputs = { "Khushbu", "khushbu", "KHUSHBU"};

            foreach (string input in inputs)
            {
                if(Regex.IsMatch(input, pattern))
                    Console.WriteLine("{0} is Valid", input);
                
                else
                   Console.WriteLine("{0} is Invalid", input);
            }
        }
        public static void LastNameValidation()
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] inputs = { "Soni", "soni", "so" };

            foreach (string input in inputs)
            {
                if (Regex.IsMatch(input, pattern))
                    Console.WriteLine("{0} is Valid", input);

                else
                    Console.WriteLine("{0} is Invalid", input);
            }
        }
        public static void EmailValidation()
        {
            //string pattern = "^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,63}$";
            string pattern = "^abc\\.[a-zA-Z]+@bl\\.co\\.[a-z]{2}$";
            string[] inputs = { "abc.xiz@bl.co.im"};

            foreach (string input in inputs)
            {
                if (Regex.IsMatch(input, pattern))
                    Console.WriteLine("{0} is Valid", input);

                else
                    Console.WriteLine("{0} is Invalid", input);
            }
        }
        public static void MobileFormat()
        {
            string pattern = "^[0-9]{2}[ ][0-9]{10}$";
            string[] inputs = {"91 94609848834"};

            foreach (string input in inputs)
            {
                if (Regex.IsMatch(input, pattern))
                    Console.WriteLine("{0} is Valid", input);

                else
                    Console.WriteLine("{0} is Invalid", input);
            }
        }
        public static void PreDefinedPasswordRule1Min8Digit()
        {
            string pattern = "^[0-9]{8,}$";
            string[] inputs = { "1234567", "123as", "123456789" };

            foreach (string input in inputs)
            {
                if (Regex.IsMatch(input, pattern))
                    Console.WriteLine("{0} is Valid", input);

                else
                    Console.WriteLine("{0} is Invalid", input);
            }
        }
    }
}
