using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<string> stack = new Stack<string>();
            foreach (var ch in input)
            {
                stack.Push(ch.ToString());
            }
            while (stack.Count > 0)
            {
                string charToPrint = stack.Pop();
                Console.Write(charToPrint);
            }
            Console.WriteLine();
        }
    }
}
