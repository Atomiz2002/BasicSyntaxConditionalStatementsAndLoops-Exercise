using System;

namespace _10._Rage_Expenses {
    class Program {
        static void Main(string[] args) {
            int games = Convert.ToInt32(Console.ReadLine());
            double headset = Convert.ToDouble(Console.ReadLine());
            double mouse = Convert.ToDouble(Console.ReadLine());
            double keyboard = Convert.ToDouble(Console.ReadLine());
            double display = Convert.ToDouble(Console.ReadLine());
            
            double expenses = games / 2 * headset;
            expenses += games / 3 * mouse;
            expenses += games / 6 * keyboard;
            expenses += games / 12 * display;
            
            
            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}