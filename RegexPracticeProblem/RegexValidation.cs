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
    }
}
