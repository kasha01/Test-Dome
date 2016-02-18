using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            String s1 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Is Palindrome: " + IsPalindrome(s1).ToString());
            Console.WriteLine();
        }

        public static bool IsPalindrome(string s1)
        {
            int l = s1.Length;
            int eIndex = s1.Length - 1;
            int bIndex = 0;
            bool result = true;

            while (eIndex != bIndex && bIndex < l - 1 && eIndex > -1)
            {
                while (s1[bIndex] == '.' || s1[bIndex] == ' ')
                {
                    bIndex = bIndex + 1;
                }

                while (s1[eIndex] == '.' || s1[eIndex] == ' ')
                {
                    eIndex = eIndex - 1;
                }

                if (bIndex < l - 1 && eIndex >= 0)
                {
                    result = s1[bIndex].ToString().ToUpper() == s1[eIndex].ToString().ToUpper() && result;
                }

                bIndex = bIndex + 1;
                eIndex = eIndex - 1;
            }
            return result;
        }
    }
}
