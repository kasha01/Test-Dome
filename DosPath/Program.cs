using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosPath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read \"Read Me\" File in the Repo");
            while (true)
            {
                Console.WriteLine("Type in a DOS path");
                string s1 = Console.ReadLine();
                Console.WriteLine("Type in CD DOS command path");
                string s2 = Console.ReadLine();

                Path path = new Path(s1);
                string result = path.CD(s2);

                Console.WriteLine();
                Console.WriteLine("You are in Path " + result);
                Console.WriteLine();

                Console.WriteLine("*********************************");
            }
        }
    }

    public class Path
    {
        private readonly Stack<string> stack;

        public Path(string path)
        {
            bool expectFolderName = false;
            string folderName = String.Empty;

            stack = new Stack<string>();
            foreach (char c in path)
            {
                if (c != '/' && expectFolderName)
                {
                    folderName = folderName + c;
                }
                else if (c == '/' && expectFolderName)
                {
                    stack.Push(folderName);
                    //expectFolderName = false;
                    folderName = String.Empty;
                }
                else if (c == '/')
                {
                    expectFolderName = true;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            //Add last character
            if (expectFolderName && folderName != String.Empty)
            {
                stack.Push(folderName);
            }
        }

        public string CD(string pathAdjustment)
        {
            string output = String.Empty;
            bool expectingFolder = false;
            string folderName = String.Empty;

            for (int i = 0; i < pathAdjustment.Length; i++)
            {
                Char thisChar = pathAdjustment[i];
                if (thisChar == '.')
                {
                    // parent
                    stack.Pop();
                    i++;
                }
                else if (thisChar != '.' && thisChar != '/' && expectingFolder)
                {
                    folderName = folderName + thisChar;
                }
                else if (thisChar == '/' && expectingFolder && folderName != String.Empty)
                {
                    stack.Push(folderName);
                    folderName = String.Empty;
                    //expectingFolder = false;
                }
                else if (thisChar == '/')
                {
                    // new folder
                    expectingFolder = true;
                    //stack.Push(pathAdjustment[i + 1]);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            //Add last character
            if (expectingFolder && folderName != String.Empty)
            {
                stack.Push(folderName);
            }

            foreach (string d in stack.Reverse())
            {
                output = output + "/" + d;
            }
            return output;
        }
    }
}
