using System;

namespace _09._Padawan_Equipment {
    class Program {
        static void Main(string[] args) {
            double money = Convert.ToDouble(Console.ReadLine());
            int students = Convert.ToInt32(Console.ReadLine());
            double priceSaber = Convert.ToDouble(Console.ReadLine());
            double priceRobe = Convert.ToDouble(Console.ReadLine());
            double priceBelt = Convert.ToDouble(Console.ReadLine());

            double priceSabers = Math.Ceiling(students * 1.10) * priceSaber;
            double priceRobes = students * priceRobe;
            double priceBelts = (students - students / 6) * priceBelt;

            double price = priceSabers + priceRobes + priceBelts;

            if (money >= price)
                Console.WriteLine($"The money is enough - it would cost {price:F2}lv.");
            else
                Console.WriteLine($"John will need {(price - money):F2}lv more.");
        }
    }
}