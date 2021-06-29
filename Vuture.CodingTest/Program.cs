using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuture.CodingTest.Business;

namespace Vuture.CodingTest
{
    public class Program
    {
        public static void Main()
        {
            TaskHelper th = new TaskHelper();

            char option = ' ';
            while (option != 'x') {
                Console.WriteLine("Please select a task: " +
                    "\n 1 - Count occurences of a letter in a string " +
                    "\n 2 - Check palindrome " +
                    "\n 3 - Count occurences of censored words in a text " +
                    "\n 4 - Censor words from list" +
                    "\n 5 - Censor palindromes" +
                    "\n x - Exit ");
                option = Console.ReadKey().KeyChar;

                switch (option)
                {
                    case '1':
                        int res1 = th.RunTaskOne();
                        break;

                    case '2':
                        bool res2 = th.RunTaskTwo();
                        break;
                    case '3':
                        List<string> res3 = th.RunTaskThreeA();
                        break;
                    case '4':
                        string[] res4 = th.RunTaskThreeB();
                        break;
                    case '5':
                        th.RunTaskThreeC();
                        break;
                    case 'x':
                        break;

                    default:
                        Console.WriteLine("Invalid task!");
                        break;

                }
            }
        }

    }
}
