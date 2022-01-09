using System;
using System.Collections.Generic;

namespace T07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>(names);

            while (kids.Count > 1)
            {
                for (int i = 1; i < number; i++)
                {
                   string kidPass = kids.Dequeue();
                    kids.Enqueue(kidPass);

                }
                string removedKid = kids.Dequeue();
                Console.WriteLine($"Removed {removedKid}");
            }
            string winner = kids.Dequeue();
            Console.WriteLine($"Last is {winner}");
        }
    }
}
