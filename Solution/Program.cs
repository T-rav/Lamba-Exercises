using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    /* Exercises: 
       > Write a program that accepts a list of numbers and displays the numbers more than a minimum
       value. Both the list of numbers and minimum value must be entered by the user via the keyboard.
       > Write a program to find and print uppercase words in a string. You may statically code the
       sentence to use, no need to have a user enter it.
     */
    class Program
    {
        static void Main(string[] args)
        {
            RunLambaListFilter();

            RunUpperCaseFilter();

            Console.ReadLine();
        }

        private static void RunUpperCaseFilter()
        {
            var upperFilter = new UpperCaseWordFilter();
            upperFilter.Run();
        }

        private static void RunLambaListFilter()
        {
            var numberInput = new LambaNumberListFilter();
            numberInput.Run();

        }
    }
}
