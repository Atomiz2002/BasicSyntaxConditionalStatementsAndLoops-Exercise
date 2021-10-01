using System;

namespace _02._Division {
    class Program {
        static void Main(string[] args) {
            int input = int.Parse(Console.ReadLine());
            int divisible;

            switch (input) {
                case { } when input % 10 == 0:
                    divisible = 10;
                    break;
                case { } when input % 7 == 0:
                    divisible = 7;
                    break;
                case { } when input % 6 == 0:
                    divisible = 6;
                    break;
                case { } when input % 3 == 0:
                    divisible = 3;
                    break;
                case { } when input % 2 == 0:
                    divisible = 2;
                    break;
                default:
                    Console.WriteLine("Not divisible");
                    return;
            }
            
            Console.WriteLine($"The number is divisible by {divisible}");
        }
    }
}