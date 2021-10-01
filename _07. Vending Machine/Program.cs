using System;

namespace _07._Vending_Machine {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            double money = 0;

            while (input != "Start") {
                switch (input) {
                    case "0.1":
                    case "0.2":
                    case "0.5":
                    case "1":
                    case "2":
                        money += double.Parse(input);
                        break;

                    default:
                        Console.WriteLine($"Cannot accept {input}");
                        break;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End") {
                double tempMoney = money;
                string product = "";

                switch (input.ToLower()) {
                    case "nuts":
                        money -= 2.0;
                        product = "nuts";
                        break;

                    case "water":
                        money -= 0.7;
                        product = "water";
                        break;

                    case "crisps":
                        money -= 1.5;
                        product = "crisps";
                        break;

                    case "soda":
                        money -= 0.8;
                        product = "soda";
                        break;

                    case "coke":
                        money -= 1.0;
                        product = "coke";
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                if (money < 0) {
                    Console.WriteLine("Sorry, not enough money");
                    money = tempMoney;
                } else if (product != "") {
                    Console.WriteLine($"Purchased {product}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {money:F2}");
        }
    }
}