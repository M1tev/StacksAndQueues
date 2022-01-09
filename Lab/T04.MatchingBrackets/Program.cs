using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startIndex = stack.Pop();
                    string content = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(content);
                }
            }
        }
    }
}
