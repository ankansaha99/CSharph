using System;

namespace _05_Operators
{
    // This class contains all operator examples
    public static class Operator
    {
        // Starting method
        public static void Run()
        {
            Introduction();
            ArithmeticOperators();
            AssignmentOperators();
            ComparisonOperators();
            LogicalOperators();
            IncrementDecrement();
            MathMethods();
        }

        // Introduction
        static void Introduction()
        {
            // Operators are used to perform operations on values
            Console.WriteLine("Operators are used to perform operations on variables and values.");

            int x = 100 + 50;
            Console.WriteLine("100 + 50 = " + x); // Output: 150

            int sum1 = 100 + 50;
            int sum2 = sum1 + 250;
            int sum3 = sum2 + sum2;

            Console.WriteLine(sum1); // 150
            Console.WriteLine(sum2); // 400
            Console.WriteLine(sum3); // 800

        }

        // Arithmetic Operators
        static void ArithmeticOperators()
        {
            int a = 10;
            int b = 3;

            Console.WriteLine(a + b); // Output: 13
            Console.WriteLine(a - b); // Output: 7
            Console.WriteLine(a * b); // Output: 30
            Console.WriteLine(a / b); // Output: 3 (int division)
            Console.WriteLine(a % b); // Output: 1 (remainder)

            // + → addition
            // - → subtraction
            // * → multiplication
            // / → division
            // % → remainder
        }

        // Assignment Operators
        static void AssignmentOperators()
        {
            int x = 10; // starting value

            // x += 5 → means x = x + 5
            // take current value of x and add 5
            x += 5;
            Console.WriteLine(x); // Output: 15 (10 + 5)

            // x -= 3 → means x = x - 3
            // subtract 3 from current value
            x -= 3;
            Console.WriteLine(x); // Output: 12 (15 - 3)

            // x *= 2 → means x = x * 2
            // multiply current value by 2
            x *= 2;
            Console.WriteLine(x); // Output: 24 (12 * 2)

            // x /= 4 → means x = x / 4
            // divide current value by 4
            x /= 4;
            Console.WriteLine(x); // Output: 6 (24 / 4)

            // x %= 5 → means x = x % 5
            // % gives remainder after division
            x %= 5;
            Console.WriteLine(x); // Output: 1 (6 % 5 = remainder 1)

            // shortcut idea:
            // x += 5 → same as x = x + 5
            // x -= 3 → same as x = x - 3
            // x *= 2 → same as x = x * 2
            // x /= 4 → same as x = x / 4
            // x %= 5 → same as x = x % 5

            Console.WriteLine();
        }

        // Comparison Operators
        static void ComparisonOperators()
        {
            int x = 5;
            int y = 3;

            Console.WriteLine(x == y); // Output: False
            Console.WriteLine(x != y); // Output: True
            Console.WriteLine(x > y);  // Output: True
            Console.WriteLine(x < y);  // Output: False
            Console.WriteLine(x >= y); // Output: True
            Console.WriteLine(x <= y); // Output: False

            // Always returns True or False
        }

        // Logical Operator
        static void LogicalOperators()
        {
            int x = 5;

            Console.WriteLine(x < 10 && x > 2); // Output: True
            Console.WriteLine(x < 4 || x < 10); // Output: True
            Console.WriteLine(!(x < 10 && x > 2)); // Output: False

            // && → both must be true
            // || → one true is enough
            // ! → reverse
        }

        // Increment Decrement
        static void IncrementDecrement()
        {
            int x = 5; // starting value

            // x++ → post-increment
            // first use the value, then increase it
            Console.WriteLine(x++); // Output: 5 (prints first, then x becomes 6)

            Console.WriteLine(x);   // Output: 6 (now value already increased)

            // ++x → pre-increment
            // first increase the value, then use it
            Console.WriteLine(++x); // Output: 7 (x becomes 7 first, then prints)

            // x-- → post-decrement
            // first use the value, then decrease it
            Console.WriteLine(x--); // Output: 7 (prints first, then x becomes 6)

            Console.WriteLine(x);   // Output: 6 (now value decreased)

            // --x → pre-decrement
            // first decrease the value, then use it
            Console.WriteLine(--x); // Output: 5 (x becomes 5 first, then prints)

        }

        // Math Methods
        static void MathMethods()
        {
            Console.WriteLine(Math.Max(5, 10)); // Output: 10
            Console.WriteLine(Math.Min(5, 10)); // Output: 5
            Console.WriteLine(Math.Sqrt(64));   // Output: 8
            Console.WriteLine(Math.Abs(-4.7));  // Output: 4.7
            Console.WriteLine(Math.Round(9.99)); // Output: 10

            // Max → largest value
            // Min → smallest value
            // Sqrt → square root
            // Abs → absolute value
            // Round → nearest whole number
        }
    }
}