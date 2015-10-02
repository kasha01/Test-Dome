using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumsOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two Sums");
            Console.WriteLine("returns zero-based indices of any two distinct elements whose sum is equal to the target sum.");
            Console.WriteLine();

            while (true)
            {
                PrintMenu();
            }            
        }

        public static void PrintMenu()
        {
            string s1 = String.Empty;
            string s2 = String.Empty;

            Console.WriteLine("Enter your intengers separateed by comma");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter Target Sum");
            s2 = Console.ReadLine();

            List<int> args = new List<int>();
            foreach (string c in s1.Split(','))
            {
                int ii = 0;
                if (int.TryParse(c.Trim(), out ii))
                {
                    args.Add(ii);
                }
            }

            int goal = 0;
            if (!int.TryParse(s2, out goal)) { return; }

            string twoSumsString = String.Empty;

            Console.WriteLine();
            Console.WriteLine("Two Sums Indexes are: " + TwoSums(args, goal, ref twoSumsString));
            Console.WriteLine(new string('*',10));
            Console.WriteLine("Two Sums Integers are: " + twoSumsString);
        }

        public static string TwoSums(List<int> list, int goalSum, ref string twoSumsString)
        {
            List<Tuple<int, int>> twoSumsIndexes = new List<Tuple<int, int>>();
            List<Tuple<int, int>> twoSumsIntegers = new List<Tuple<int, int>>();

            // Work
            for (int i = 0; i < list.Count; i++)
            {
                int n1 = list[i];

                for (int j = 0; j < list.Count; j++)
                {
                    if (n1 + list[j] == goalSum)
                    {
                        twoSumsIndexes.Add(new Tuple<int, int>(i, j));
                        twoSumsIntegers.Add(new Tuple<int, int>(n1, list[j]));
                    }
                }
            }

            if(twoSumsIndexes.Count <= 0) {
                twoSumsString = String.Empty;
                return "No Result was found";
            }

            //Built TwoSums Integers string
            StringBuilder sb2 = new StringBuilder();
            sb2.AppendLine();
            foreach (var item in twoSumsIntegers)
            {
                sb2.Append(item.Item1);
                sb2.Append(',');
                sb2.Append(item.Item2);
                sb2.AppendLine();
            }
            twoSumsString = sb2.ToString();

            //Build TwoSums Indexes string
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            foreach (var item in twoSumsIndexes)
            {
                sb.Append(item.Item1);
                sb.Append(',');
                sb.Append(item.Item2);
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
