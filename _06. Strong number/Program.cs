using System;

namespace _06._Strong_number {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < input.Length; i++) { // for each digit in the number sequence
                int factorial = 1;

                for (int j = 1; j <= int.Parse(input[i].ToString()); j++) { // get the respective digit
                    factorial *= j; // find its factorial (multiply its digits [1*2*3...])
                }

                sum += factorial; // add the factorial to the sum
            }

            if (int.Parse(input) == sum) // compare the input and sum
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}