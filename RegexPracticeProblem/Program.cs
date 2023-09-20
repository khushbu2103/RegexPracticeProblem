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
            Console.WriteLine("1.FirstNameValidation\n2.LastNameValidation\n3.EmailValidation");
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
            }
           
            Console.ReadLine();
        }
    }
}
