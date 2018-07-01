using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calculator1
{
    public static class Validator
    {
        private static bool StartsAndEndsWithNumbers(string s)
        {
            return char.IsDigit(s.ToCharArray().First()) && char.IsDigit(s.ToCharArray().Last());
        }

        private static bool CheckIfThereAreNoCharacters(string s)
        {
            return Regex.Matches(s, @"[a-zA-Z]").Count == 0;
        }

        private static bool CheckIfConsequtiveItemsAreOnlyNumbers(string s)
        {
            char[] array = s.ToCharArray();
            int counter = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                char k = array[i];
                if (!char.IsDigit(k))
                {
                    ++counter;
                    if (counter > 1)
                        break;
                }
                else
                {
                    counter = 0;
                }
            }
            
            return counter == 0;
        }
        
        public static bool ValidateEquation(string s)
        {
            return !string.IsNullOrWhiteSpace(s) 
                && StartsAndEndsWithNumbers(s) 
                && CheckIfThereAreNoCharacters(s) 
                && CheckIfConsequtiveItemsAreOnlyNumbers(s);
        }
    }
}
