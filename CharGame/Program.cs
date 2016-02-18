using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = String.Empty;
            Console.WriteLine("Enter String");
            s1 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Longest Run Letter Index is: " + IndexofLongestRun(s1).ToString());
            Console.WriteLine();
        }

        public static int IndexofLongestRun(string s1)
        {
            int maxCounter = 0;
            int currentcounter = 0;
            char currentChar = s1[0];
            int myindex = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != currentChar)
                {
                    // Change
                    if (currentcounter > maxCounter)
                    {
                        maxCounter = currentcounter;
                        myindex = i - currentcounter;
                    }
                    currentcounter = 1;
                    currentChar = s1[i];
                }
                else
                {
                    currentcounter++;
                }
            }

            // Last Character
            if (currentcounter > maxCounter)
            {
                maxCounter = currentcounter;
                myindex = s1.Length - currentcounter;
            }
            return myindex;
        }
    }
}
