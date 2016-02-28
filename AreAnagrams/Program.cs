using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = String.Empty;
            string s2 = String.Empty;
            Console.WriteLine("Check if two strings are anagrams of each other");
            Console.WriteLine("Enter First String");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter Second String");
            s2 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ara Anagram: " + AreStringsAnagrams(s1, s2).ToString());
            Console.ReadLine();
        }

        public static bool AreStringsAnagrams(string s1, string s2)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in s1)
            {
                if (!dic.ContainsKey(c))
                {
                    dic.Add(c, 1);
                }
                else
                {
                    dic[c] = dic[c] + 1;
                }
            }

            foreach (char c in s2)
            {
                if (!dic.ContainsKey(c) || dic[c] <= 0)
                {
                    return false;
                }
                else
                {
                    dic[c] = dic[c] - 1;
                }
            }
            return true;
        }
    }
}
