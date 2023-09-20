using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Choose any program");
            Console.WriteLine("1.FirstNameValidation\n" +
                "2.LastNameValidation\n" +
                "3.EmailValidation\n" +
                "4.PreDefinedMobileFormat\n" +
                "5.PreDefinedPasswordRule1Min8Digit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    RegexValidation.FirstNameValidation();
                    break;

                case 2:
                    RegexValidation.LastNameValidation();
                    break;
                case 3:
                    RegexValidation.EmailValidation();
                    break;
                case 4:
                    RegexValidation.MobileFormat();
                    break;
                case 5:
                    RegexValidation.PreDefinedPasswordRule1Min8Digit();
                    break;
            }
           
            Console.ReadLine();
        }
    }
}
