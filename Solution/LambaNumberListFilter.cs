using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    public class LambaNumberListFilter
    {
        public void Run()
        {
            var userInput = GetUserInput();

            var result = GetNumbersLargerThanMininum(userInput);
            var formatedResult = FormatForPrint(result);

            Console.WriteLine($"Here are the numbers greater than {userInput.Min} : {formatedResult}");
        }

        private string FormatForPrint(IEnumerable<int> result)
        {
            var print = String.Join(",", result);
            return print;
        }

        private IEnumerable<int> GetNumbersLargerThanMininum(NumberListInputTo userNumberListInput)
        {
            var result = userNumberListInput.Numbers.Where(item => item > userNumberListInput.Min);
            return result;
        }

        private NumberListInputTo GetUserInput()
        {
            Console.WriteLine("Please enter a space separated list of numbers:");
            var numbers = Console.ReadLine();
            Console.WriteLine("Enter minimum value to filter on: ");
            var minValue = Console.ReadLine();

            var min = ConvertMinToInteger(minValue);
            var numberList = ConvertNumberListToIntegers(numbers);

            return new NumberListInputTo { Min = min, Numbers = numberList };
        }

        private IEnumerable<int> ConvertNumberListToIntegers(string numbers)
        {
            var tokens = numbers.Split(' ');
            var numberList = tokens.Select(Int32.Parse);
            return numberList;
        }

        private int ConvertMinToInteger(string min)
        {
            var minInt = Int32.Parse(min);
            return minInt;
        }
    }
}