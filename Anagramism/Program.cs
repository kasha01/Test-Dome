using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAnagrams
{
    class Program
    {
        static List<char[]> allAnagramsList = new List<char[]>();
        static void Main(string[] args)
        {
            string inputString = String.Empty;
            Stack<char> st = new Stack<char>();

            Console.WriteLine("Find All Anagrams of a string (Find all possible combination)");
            Console.WriteLine("Enter First String");
            inputString = Console.ReadLine();
            Console.WriteLine();

            Node node = new Node();
            getAllAnagrams(inputString, st, ref node);

            Console.WriteLine("All Angrams are:");
            Console.WriteLine("==========================================");
            int i = 0;
            foreach (char[] t in allAnagramsList)
            {
                i++;
                Console.WriteLine(i + ". " + string.Join("", t));
            }
            Console.ReadLine();
        }

        private static void getAllAnagrams(string s, Stack<char> st, ref Node n)
        {
            if (s.Length <= 0)
            {
                // End of tree branch - flatten the stack and add it to Anagrams list.
                allAnagramsList.Add(st.Select(q => q).ToArray());
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (n != null && !n.nodeList.Exists(x => x.value == s[i]))
                {
                    Node newnode = new Node();
                    newnode.value = s[i];
                    st.Push(s[i]);
                    n.nodeList.Add(newnode);
                    string temp = s.Remove(i, 1);
                    getAllAnagrams(temp, st, ref newnode);
                    st.Pop();
                }
            }
        }

        class Node
        {
            public List<Node> nodeList { get; set; }
            public char value { get; set; }

            public Node()
            {
                nodeList = new List<Node>();
            }
        }
    }
}
