﻿using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i <= 20; i++)
            {
                numbers.Add(random.Next(1, 51));

            };

            List<int> squareNumList = new List<int>();

            foreach (var nums in numbers)
            {
                squareNumList.Add(nums ^ 2);
            }
            squareNumList.RemoveAll(i => i % 2 != 0);
            foreach (var oddNums in squareNumList)
            {
                Console.WriteLine(oddNums);
            }
        }
    }
}
