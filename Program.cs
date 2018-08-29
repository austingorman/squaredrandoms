using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        g
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i <= 20; i++)
            {
                numbers.Add(random.Next(1, 51));

            };

            List<Double> squareNumList = new List<Double>();

            foreach (var nums in numbers)
            {
                // double squared = Math.Pow(nums, 2);
                // List<int> squared = new List<int>();
                squareNumList.Add(Math.Pow(nums, 2));
            }
            squareNumList.RemoveAll(i => i % 2 != 0);
            foreach (var oddNums in squareNumList)
            {
                Console.WriteLine(oddNums);
            }
        }
    }
}
