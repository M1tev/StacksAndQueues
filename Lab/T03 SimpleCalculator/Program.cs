using System;
using System.Collections.Generic;
using System.Linq;

namespace T03_SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split().Reverse().ToArray();
            Stack <string> stack = new Stack<string>(input);
            string result = "";

            while (stack.Count > 1)
            {
                int num1 = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int num2 = int.Parse(stack.Pop());
                if (operation == "+")
                {
                     result = (num1 + num2).ToString();
                }
                else
                {
                     result = (num1 - num2).ToString();
                }
                stack.Push(result);
            }
            string finalResult = stack.Pop();
            Console.WriteLine(finalResult);
        }
    }
}
 