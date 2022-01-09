using System;
using System.Collections.Generic;

namespace T08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int passCount = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();

            int count = 0;

            while (input != "end")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    if (cars.Count >= passCount)
                    {
                        for (int i = 0; i < passCount; i++)
                        {
                            string passedCar = cars.Dequeue();
                            Console.WriteLine($"{passedCar} passed!");
                            count++;
                        }
                    }
                    else
                    {
                        while (cars.Count > 0)
                        {
                            string passedCar = cars.Dequeue();
                            Console.WriteLine($"{passedCar} passed!");
                            count++;
                        }
                    }

                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
