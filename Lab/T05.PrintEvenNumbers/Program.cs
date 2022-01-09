using System;
using System.Linq;
using System.Collections.Generic;

namespace T05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            int index = 0;

            while (queue.Count > 0)
            {
                int crrNum = queue.Peek();
                if (crrNum % 2 == 0)
                {

                    if (index == 0)
                    {
                        int numToPrint = queue.Dequeue();
                        Console.Write($"{numToPrint}");
                        index++;
                    }
                    else
                    {
                        int numToPrint = queue.Dequeue();
                        Console.Write($", {numToPrint}");
                    }
                }
                else
                {
                    queue.Dequeue();
                }
            }


            Console.WriteLine();
        }
    }
}
