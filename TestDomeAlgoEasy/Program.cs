using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDomeAlgoEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                PrintMenu();
            }
        }

        public static void PrintMenu()
        {
            Console.WriteLine("Choose Function to Run: ");
            Console.WriteLine("Press 1 - TwoSums");
            Console.WriteLine("Press 2 - Frog Leap");

            string s1 = String.Empty;
            string s2 = String.Empty;
            int opt = 0;
            string r = Console.ReadLine();
            bool a = int.TryParse(r, out opt);
            if (a)
            {
                switch (opt)
                {
                    case 1:
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

                        Console.WriteLine();
                        Console.WriteLine("Two Sums Are Indexes are: " + TwoSums(args, goal));
                        Console.WriteLine();
                        break;

                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
        }

        public static string TwoSums(List<int> list, int goalSum)
        {
            List<Tuple<int, int>> twoSums = new List<Tuple<int, int>>();
            for (int i = 0; i < list.Count; i++)
            {
                int n1 = list[i];

                for (int j = 0; j < list.Count; j++)
                {
                    if (n1 + list[j] == goalSum)
                    {
                        twoSums.Add(new Tuple<int, int>(i, j));
                    }
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            foreach (var item in twoSums)
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

