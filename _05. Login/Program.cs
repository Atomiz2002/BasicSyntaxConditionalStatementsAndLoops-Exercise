using System;
using System.Linq;

namespace _05._Login {
    class Program {
        static void Main(string[] args) {
            string username = Console.ReadLine();
            string password = new string(username.Reverse().ToArray());
            int attempts = 0;

            while (Console.ReadLine() != password) {
                if (attempts >= 3) {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                } else {
                    Console.WriteLine("Incorrect password. Try again.");
                    attempts++;
                }
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}