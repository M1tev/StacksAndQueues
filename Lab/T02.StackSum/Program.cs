using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] commands = Console.ReadLine().Split();

            Stack<int> stack = new Stack<int>(input);
            int sum = 0;

            while (commands[0].ToLower() != "end")
            {
                if (commands[0].ToLower() == "add")
                {
                    stack.Push(int.Parse(commands[1]));
                    stack.Push(int.Parse(commands[2]));
                }
                else if (commands[0].ToLower() == "remove")
                {
                    int count = int.Parse(commands[1]);
                    if (stack.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                   
                }
                commands = Console.ReadLine().Split();
            }

            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
