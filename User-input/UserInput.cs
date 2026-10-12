// Importing System namespace to use built-in things like Console
using System;

// Namespace → helps organize code and avoid naming conflicts
namespace _04_UserInput
{
    // 'public' means this class can be accessed from outside this file/project
    // 'static' means we do not need to create an object to use this class
    // 'class' is like a container that holds methods
    public static class UserInput
    {
        // 'void' means this method does not return any value
        // 'Run' is the starting method for this file
        public static void Run()
        {
            RunUserInputSection();
            UserInputWithHelpers();
        }

        // User Input
        static void RunUserInputSection()
        {
            Console.WriteLine("Enter your name:");

            // Read input from user
            // ?? "" means if input is null, use empty string instead
            string name = Console.ReadLine() ?? "";

            Console.WriteLine("Hello " + name);

            Console.WriteLine("Enter your age:");

            // Read age as text
            string ageText = Console.ReadLine() ?? "";

            // TryParse tries to convert string → int
            // ageText = input (string)
            // out int age = store converted number in 'age'
            // 'out' means: store the result in this variable 'age'

            // If conversion is successful → returns true and stores the real number in 'age'

            // If conversion fails → returns false
            // but 'age' still needs a value (because of 'out')
            // because 'out' always needs a value before the method finishes
            // so C# gives default values: int → 0, double → 0.0, bool → false, string → null

            if (int.TryParse(ageText, out int age))
            {
                Console.WriteLine("Your age is: " + age);
            }
            else
            {
                Console.WriteLine("Invalid age input");
            }
        }

        // User Input - With Helper Method
        static void UserInputWithHelpers()
        {
            // Calling ReadString method and storing the returned value in 'name'
            string name = ReadString("Enter your name:");
            Console.WriteLine("Hello " + name);

            // Calling ReadInt method and storing the result in 'age'
            // int? means nullable int - It can store a number or null
            int? age = ReadInt("Enter your age:");

            // HasValue checks whether age contains a real value
            if (age.HasValue)
            {
                Console.WriteLine("Your age is: " + age);
            }
            else
            {
                Console.WriteLine("Invalid age input");
            }

            // Read salary using helper method
            // double? means nullable double - It can store a decimal number or null
            double? salary = ReadDouble("Enter your salary:");

            if (salary.HasValue)
            {
                Console.WriteLine("Your salary is: " + salary);
            }
            else
            {
                Console.WriteLine("Invalid salary input");
            }

            Console.WriteLine();
        }

        // This method reads string input
        static string ReadString(string message)
        {
            // 'message' is a variable that receives a value from outside
            // Show the message first (Enter your name:)
            Console.WriteLine(message);

            // ReadLine reads input as text
            // ?? "" protects from null
            return Console.ReadLine() ?? "";
        }

        // This method reads integer input
        static int? ReadInt(string message)
        {
            // Show message first
            Console.WriteLine(message);

            // Read input as string
            string input = Console.ReadLine() ?? "";

            // Try to convert string to int
            if (int.TryParse(input, out int value))
            {
                return value;
            }

            // Return null if conversion fails
            return null;
        }

        // This method reads double input
        static double? ReadDouble(string message)
        {
            // Show message first
            Console.WriteLine(message);

            // Read input as string
            string input = Console.ReadLine() ?? "";

            // Try to convert string to double
            if (double.TryParse(input, out double value))
            {
                return value;
            }

            // Return null if conversion fails
            return null;
        }

        // Example 1: Returning 0 (Confusing)
        // This method returns int (NOT nullable)
        static int GetAge(string input)
        {
            // Try to convert string → int
            if (int.TryParse(input, out int value))
            {
                return value; // valid number
            }

            // If conversion fails → return 0
            return 0; // Problem: 0 could be a real value OR invalid input
        }

        // Example 2: Returning null (Better)
        // This method returns nullable int
        static int? GetAgeSafe(string input)
        {
            // Try to convert string → int
            if (int.TryParse(input, out int value))
            {
                return value; // valid number
            }

            // If conversion fails → return null
            return null;
        }

        // return 0 → confusing (0 can be real value or error)
        // return null → clear (no value = invalid input)

        // Example:
        // Input "0"   → return 0 (this is correct, user entered 0)

        // Input "abc" → return 0 ❌ (wrong, because user did NOT enter 0)
        //              → return null ✅ (correct, because input is invalid)

        // Value always valid   -> int, double                 
        // Value can be invalid -> int?, double? + return null 
    }
}