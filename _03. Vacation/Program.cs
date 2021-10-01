using System;

namespace _03._Vacation {
    class Program {
        static void Main(string[] args) {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.00;
            double total = 0.00;

            switch (type) {
                case "Students":
                    if (day == "Friday") price = 8.45;
                    else if (day == "Saturday") price = 9.80;
                    else if (day == "Sunday") price = 10.46;

                    total = people * price;

                    if (people >= 30)
                        total -= total * 0.15;

                    break;

                case "Business":
                    if (day == "Friday") price = 10.90;
                    else if (day == "Saturday") price = 15.60;
                    else if (day == "Sunday") price = 16.00;

                    total = people * price;

                    if (people >= 100)
                        total -= price * 10;

                    break;

                case "Regular":
                    if (day == "Friday") price = 15.00;
                    else if (day == "Saturday") price = 20.00;
                    else if (day == "Sunday") price = 22.50;

                    total = people * price;

                    if (people >= 10 && people <= 20)
                        total -= total * 0.05;

                    break;
            }

            Console.WriteLine($"Total price: {total:F2}");
        }
    }
}