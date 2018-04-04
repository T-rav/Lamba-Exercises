using System;
using System.Collections.Generic;

namespace Solution
{
    public class UpperCaseWordFilter
    {
        public void Run()
        {
            var sentence = "The QUICK brown FOX JUMPED OVER THE LAZY doG";
            Console.WriteLine($"UpperCase Word Filter on '{sentence}'");

            Func<string, IEnumerable<string>> findUppercaseWords = input =>
            {
                var result = new List<string>();
                var tokens = input.Split(' ');
                foreach (var token in tokens)
                {
                    if (UpperCaseWord(token))
                    {
                        result.Add(token);
                    }
                }

                return result;
            };
            var uppercaseWords = findUppercaseWords(sentence);
            var print = String.Join(",", uppercaseWords);
            Console.WriteLine(print);
        }

        private static bool UpperCaseWord(string token)
        {
            return token.ToUpper() == token;
        }
    }
}