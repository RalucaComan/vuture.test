
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vuture.CodingTest.Business
{
    public class TaskHelper
    {
        readonly string[] censoredWords = { "dog", "cat", "large" };
        readonly string sampleText = "I have a cat named Meow and a dog name Woof. I love the dog a lot. He is larger than a small horse.";
        readonly string sampleText2 = "Anna went to vote in the election to fulfil her civic duty";
        readonly char[] delimiters = { ' ', ',', '.', ':', ';' };

        //Task A: Create a function which counts the number of occurrences of a given letter in a string.
        public int RunTaskOne()
        {
           
            Console.Write("\n Please choose LETTER:   ");
            char letter = Console.ReadKey().KeyChar;
            Console.Write("\n Please choose TEXT:  ");
            string text = Console.ReadLine();
            int result = HelperFunctions.CountOccurences(text, letter);
            Console.WriteLine("\n  OUTPUT: " + result);
            Console.ReadKey();
            return result;
        }
        // Task 2: Create a function which decides if a string is a palindrome.
        public bool RunTaskTwo()
        {
            Console.Write("\n Please choose TEXT:  ");
            string text = Console.ReadLine().Trim();
            //text = Regex.Replace(text, @"[^a-z]+", "");
            bool result = HelperFunctions.IsPalindromeIterative(text);
            Console.WriteLine("\n  ITERATIVE OUTPUT: " + result);
            Console.WriteLine("\n  RECURSIVE OUTPUT: " + HelperFunctions.IsPalindrome(text));
            Console.ReadKey();
            return result;
        }

        // Task 3A: Create a function which counts the number of occurrences of words from a "censored words list" in a text.
        public List<string>  RunTaskThreeA()
        {
            List<string> result = HelperFunctions.CountCensoredWordsOccurences(censoredWords, sampleText);
            Console.WriteLine();
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
            return result;
        }

        // Task 3B: Create a way to censor words featured in the "censored words list" that appear in the text.
        // Note: my solution recognizes a perfect mathc in the next, so it doesn't count larger as being the same as large ( as shown in your output example.)
        public string[] RunTaskThreeB()
        {
            string[] testWords = sampleText.Split(delimiters);
            string[] resultWords = testWords;
            for (int i = 0; i < testWords.Length - 1; i++)
            {
                if (censoredWords.Contains(testWords[i]))
                {
                   resultWords[i] = HelperFunctions.CensorWordWithRegex(testWords[i]);
                }
            }
            Console.WriteLine();
            foreach (string word in resultWords)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();

            return resultWords;
        }

        // Task 3C: Create a way to censor a single word palindrome in a text.
        public void RunTaskThreeC()
        {
            string[] testWords = sampleText2.Split(delimiters);
            string[] resultWords = testWords;
            for (int i = 0; i < testWords.Length - 1; i++)
            {
                string test = testWords[i].ToLower();
                test = Regex.Replace(test, @"[^a-z]+", "");
                if (HelperFunctions.IsPalindrome(testWords[i]))
                {
                    Console.WriteLine(test);
                    resultWords[i] = HelperFunctions.CensorWordWithRegex(testWords[i]);
                }
                else
                {
                    resultWords[i] = testWords[i];
                }
         
            }
            Console.WriteLine();
            foreach (string word in resultWords)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();

        }

        // Task 3D: Come up with at least 3 different ways to provide the "censored words list" to the application.
        // This task does not require coding, please send us  3 bullet points on how you would do this. 
        /* 
           1. From any type of database 
           2. From a resource file added to the project. Can be text, csv, xml, json
           3. From a sessionStorage or localStorage
           4. From an API
         
         */
    }
}
