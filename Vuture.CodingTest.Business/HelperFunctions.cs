using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vuture.CodingTest.Business
{
    public static class HelperFunctions
    {
        public static int CountOccurences(string inputString, char letter)
        {
            int nrOfOccurences = 0;

            foreach (char ch in inputString)
            {
                if ( ch == letter)
                {
                    nrOfOccurences++;
                }
            }

            return nrOfOccurences;
        }

  
        public static bool IsPalindromeIterative(string input)
        {
            if (input.Length == 1)
            {
                return true;
            }
             string reversed = Reverse(input);
             if ( string.Compare(input,reversed,true) == 0)
            {
                return true;
            }
           return false;
        }

        public static string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new String(chars);
        }


        public static bool IsPalindromeRecursive ( string input, int left, int right)
        {
            if ( left > right )
            {
                return true;
            }
           
            if (string.Compare(input[left].ToString(),input[right].ToString(), true) != 0 )
            {
                return false;
            }
            else
            {
                return IsPalindromeRecursive(input, left + 1, right - 1);
            }

        }

        public static bool IsPalindrome(string input)
        {
            if (input.Length == 1)
            {
                return true;
            }
            return IsPalindromeRecursive(input, 0, input.Length -1);
        }

        public static string CensorWord(string input)
        {
            string output = "" + input[0];
            for (int i=1; i<input.Length-2; i++)
            {
                output += '$';
            }
            return output + input[input.Length-1];
        }

        public static string CensorWordWithRegex(string input)
        {
            string output = Regex.Replace(input, @"(?!^|.$)[^.]" , "$");
            return output;
        }

        public static List<string> CountCensoredWordsOccurences(string[] censoredWords, string inputText)
        {
            int total = 0;
            int counter;
            char[] delimiters = { ' ', ',', '.', ':', ';' };
            string[] inputWords = inputText.Split(delimiters);
            List<string> output = new List<string>();
            foreach (string cWord in censoredWords)
            {
                counter = 0;
                for (int i=0; i< inputWords.Length-1; i++)
                {
                    if ( cWord == inputWords[i] )
                    {
                        counter++;
                    }
                }
                output.Add( cWord + ": " + counter + "  ");
                total += counter;                
            }
            output.Add("total: " + total);
            return output;
        }

       
    }
}
