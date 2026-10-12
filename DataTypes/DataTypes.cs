using System;

namespace _03_DataTypes
{
    // This class contains all data type examples
    public static class DataTypes
    {
        // Starting method
        public static void Run()
        {
            Introduction();
            CommonDataTypes();
            IntegerTypes();
            FloatingPointTypes();
            ScientificNumbers();
            BooleanType();
            CharacterType();
            StringType();
            TypeCasting();
            ConvertMethods();
        }

        // Introduction
        static void Introduction()
        {
            // A data type tells what kind of value a variable can store
            Console.WriteLine("A data type defines what kind of value a variable can hold.");

            // Example:
            // int → stores whole numbers
            // string → stores text

            Console.WriteLine("Using correct data types makes code safe and clear.");
        }

        // Common DataTypes
        static void CommonDataTypes()
        {
            int number = 5;           // whole number
            double price = 5.99;      // decimal number
            char letter = 'A';        // single character
            bool isActive = true;     // true / false
            string text = "Hello";    // text

            Console.WriteLine("int: " + number);
            Console.WriteLine("double: " + price);
            Console.WriteLine("char: " + letter);
            Console.WriteLine("bool: " + isActive);
            Console.WriteLine("string: " + text);

            // Simple idea:
            // int → whole number
            // double → decimal
            // char → one character
            // bool → true/false
            // string → text
        }

        // Integer Types
        static void IntegerTypes()
        {
            int normalNumber = 100000;           // common use
            long bigNumber = 15000000000L;       // large numbers

            Console.WriteLine("int: " + normalNumber);
            Console.WriteLine("long: " + bigNumber);

            // int → smaller range
            // long → bigger range

            Console.WriteLine("Use int for normal numbers.");
            Console.WriteLine("Use long for very large numbers.");
        }

        // Floating Point Types
        static void FloatingPointTypes()
        {
            float smallDecimal = 5.75F;     // less precise
            double bigDecimal = 19.99;      // more precise

            Console.WriteLine("float: " + smallDecimal);
            Console.WriteLine("double: " + bigDecimal);

            // float → less precision
            // double → more precision (better)

            Console.WriteLine("double is usually better for calculations.");
        }

        // Scientific Numbers
        static void ScientificNumbers()
        {
            float f = 35e3F;   // 35 * 10^3
            double d = 12E4;   // 12 * 10^4

            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
        }

        // Boolean Type
        static void BooleanType()
        {
            bool isGood = true;
            bool isBad = false;

            Console.WriteLine("isGood: " + isGood);
            Console.WriteLine("isBad: " + isBad);

            // bool → only true or false
        }

        // Character Type
        static void CharacterType()
        {
            char grade = 'A';

            Console.WriteLine("Grade: " + grade);

            // char → single character
            // uses single quotes: 'A'
        }

        // String Type
        static void StringType()
        {
            string message = "Hello World";

            Console.WriteLine("Message: " + message);
           
            // string → text
            // uses double quotes: "Hello"
        }

        // Type Casting
        static void TypeCasting()
        {
            // Implicit (automatic)
            int num = 9;
            double converted = num;

            Console.WriteLine("int → double: " + converted); // Output: int → double: 9 (stored as 9.0)

            // Explicit (manual)
            double price = 9.78;
            int newNum = (int)price;

            Console.WriteLine("double → int: " + newNum); // Output: double → int: 9 (decimal part removed)

            // Implicit casting → automatic (small type → bigger type)
            // char → int → long → float → double

            // Explicit casting → manual (big type → smaller type)
            // double → float → long → int → char
        }

        // Convert Methods
        static void ConvertMethods()
        {
            int num = 10;
            double price = 5.25;
            bool isActive = true;

            Console.WriteLine(Convert.ToString(num));      // Output: "10" (int → string)
            Console.WriteLine(Convert.ToDouble(num));      // Output: 10 (int → double → 10.0)
            Console.WriteLine(Convert.ToInt32(price));     // Output: 5 (double → int, decimal part removed)
            Console.WriteLine(Convert.ToString(isActive)); // Output: "True" (bool → string)

            // Convert helps change data types easily
        }

    }
}