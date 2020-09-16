

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    class Program
    {
        static int ASCII_SIZE = 256;
        static string getMaxOccuringChar(String str)
        {

            // Array created and key count of individual character and initialize with zero value
            int[] count = new int[ASCII_SIZE];

            int max = -1; // Initialize max count 
            char result = ' '; // Initialize result 


            // update  character count array from the input string. 
            //maintain the count of each character
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                count[str[i]]++;

                if (max < count[str[i]])
                {
                    max = count[str[i]];
                    result = str[i];
                }

            }

            return "Frequent Character: " + result + ",Count: " + max.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");

            // string variable created and get user input from the keyboard and store it in the variable
            string str = Console.ReadLine();
            Console.Write(getMaxOccuringChar(str.ToLower(new CultureInfo("en-US", false)))); /// Convert string to lower case using Culture info as A is same as a
            Console.ReadKey();
        }
    }
}

