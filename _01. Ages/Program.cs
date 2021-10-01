using System;

namespace Basic_Syntax_Conditional_Statements_and_Loops___Exercise {
    class Program {
        static void Main() {
            var age = int.Parse(Console.ReadLine());
            var person = "";

            if (age >= 0)
                switch (age) {
                    case {} when age <= 2:
                        person = "baby";
                        break;
                    case {} when age <= 13:
                        person = "child";
                        break;
                    case {} when age <= 19:
                        person = "teenager";
                        break;
                    case {} when age <= 65:
                        person = "adult";
                        break;
                    default:
                        person = "elder";
                        break;
                }

            Console.WriteLine(person);
        }
    }
}