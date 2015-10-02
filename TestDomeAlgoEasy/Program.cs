using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDomeAlgoEasy
{
    class Program
    {
        public static List<move[]> lisofpathes;

        static void Main(string[] args)
        {
            Console.WriteLine("Frog Leap: Calculates the number of different combinations a frog can use to cover a given distance");
            Console.WriteLine(new string('*', 20));

            while (true)
            {
                PrintMenu();
            }
        }

        public static void PrintMenu()
        {
            Console.WriteLine("Enter your distance for Froggie to walk in");
            string s1 = Console.ReadLine();
            int goal = 0;
            if (!int.TryParse(s1, out goal)) { return; }

            lisofpathes = new List<move[]>();
            Node rootNode = new Node(move.none);
            Stack<move> pathStack = new Stack<move>();

            Frog(rootNode, goal, pathStack);

            if(lisofpathes.Count <= 0 || lisofpathes[0].Length <= 0) { Console.WriteLine("No distance for Froggie to walk"); return; }

            //Print All Possible Pathes
            Console.WriteLine("Froggie possible pathes are: ");
            StringBuilder sb = new StringBuilder();
            foreach (move[] path in lisofpathes)
            {
                foreach (move p in path)
                {
                    sb.Append(p);
                    sb.Append(',');
                }
                sb.Remove(sb.Length - 1, 1);
                Console.WriteLine(sb.ToString());
                sb.Clear();
            }
            Console.WriteLine(new string('*', 20));
        }

        public static void Frog(Node node, int steps, Stack<move> stack)
        {
            if (steps > 1)
            {
                //If remaining steps > 1 (meaning froggies can either Jump or Step)
                for (int i = 0; i < 2; i++)
                {
                    //Each Parent Node has Two Child Nodes
                    if (i == 0)
                    {
                        //First Child Node - Holds the Jump
                        node.LNode = new Node(move.jump);   //Move to the Left Node
                        Node n = node.LNode;                //Pass in the Left Node
                        int s = steps - 2;                  //Hold in the remaining steps, when the recurssive Frog returns, the number of steps before the recurssive call (no of steps at the parent node) will apply.
                        stack.Push(move.jump);              //push froggie move into the stack
                        Frog(n, s, stack);
                        stack.Pop();                        //pop the child node step, stack pointer now points at the parent node step
                    }
                    else if (i == 1)
                    {
                        //Second Child Node - Holds the Step
                        node.RNode = new Node(move.step);
                        Node n = node.RNode;
                        int s = steps - 1;
                        stack.Push(move.step);
                        Frog(n, s, stack);
                        stack.Pop();
                    }
                }
            }
            else if (steps == 1)
            {
                //If remaining step is Only 1: Froggie can only Step, he/she cannot jump
                node.CNode = new Node(move.step);
                int s = steps - 1;
                stack.Push(move.step);
                Frog(node, s, stack);
                stack.Pop();
            }
            else if (steps <= 0)
            {
                //If remaining steps is zero: No more remaining steps - Log the stack which has the path Froggie made
                // add pathStack to list of pathes
                move[] a = stack.Select(q => q).ToArray();
                lisofpathes.Add(a);
            }
        }
    }

    enum move
    {
        none,
        step,
        jump
    }

    class Node
    {
        public move value { get; set; }
        public Node RNode { get; set; }
        public Node LNode { get; set; }
        public Node CNode { get; set; }

        private Node() { }

        public Node(move move)
        {
            this.value = move;
        }
    }
}

