﻿using System;

namespace _04._Print_And_Sum {
    class Program {
        static void Main(string[] args) {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = start; i <= end; i++) {
                Console.Write($"{i} ");
                sum += i;
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}