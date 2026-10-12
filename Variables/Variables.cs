using System;

namespace _02_Variables
{
    // This class contains all variable-related examples
    public static class Variables
    {
        // Starting method
        public static void Run()
        {
            Introduction();
            DeclareVariables();
            AssignLater();
            ReassignValue();
            DisplayVariables();
            CombineVariables();
            MultipleVariables();
            Identifiers();
            Constants();
            VarKeyword();
        }

        // Introduction
        static void Introduction()
        {
            Console.WriteLine("A variable is a container that stores a value.");
            Console.WriteLine("Each variable has:");
            Console.WriteLine("- Data type (what kind of data)");
            Console.WriteLine("- Name (identifier)");
            Console.WriteLine("- Value (stored data)");

            // Example:
            // int age = 25;
            // int  → data type
            // age  → variable name
            // 25   → value
        }


        // Declare Variables
        static void DeclareVariables()
        {
            // string → text
            string name = "Yash";

            // int → whole number
            int number = 15;

            // double → decimal number
            double price = 5.99;

            // char → single character
            char letter = 'R';

            // bool → true/false
            bool isActive = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Number: " + number);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Letter: " + letter);
            Console.WriteLine("Active: " + isActive);
            
            // Different data types store different kinds of values
        }

      
        // Declare First, Assign Later
        static void AssignLater()
        {
            int value; // declared
            value = 25; // assigned later

            Console.WriteLine("Value: " + value);
            // You must assign a value before using the variable
        }

        // Reassign Value
        static void ReassignValue()
        {
            int number = 10;
            Console.WriteLine("Before: " + number); // 10

            // changing value
            number = 20;

            Console.WriteLine("After: " + number); // 20
            // Normal variables can change
        }

        // Display Variable
        static void DisplayVariables()
        {
            string name = "Rohan";
            Console.WriteLine("Hello " + name); 

            int x = 5;
            int y = 6;

            Console.WriteLine("x + y = " + (x + y));

            // + with string → join text
            // + with numbers → addition
        }

        // Combine Variables
        static void CombineVariables()
        {
            string firstName = "Yash";
            string lastName = "Rohan";

            string fullName = firstName + " " + lastName;

            Console.WriteLine("Full Name: " + fullName);
            // String + String = combined text
        }

        // Multiple Variable
        static void MultipleVariables()
        {
            int a = 5, b = 6, c = 50;

            Console.WriteLine("Sum: " + (a + b + c));

            int x, y, z;
            x = y = z = 100;

            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.WriteLine("z: " + z);
           
            // You can declare multiple variables but avoid overusing in real projects
        }


        // Identifiers
        static void Identifiers()
        {
            int minutesPerHour = 60;

            Console.WriteLine("Example: " + minutesPerHour);

            Console.WriteLine("Rules:");
            Console.WriteLine("- Use letters, digits, underscore");
            Console.WriteLine("- Must start with letter or _");
            Console.WriteLine("- No spaces");
            Console.WriteLine("- Case-sensitive");
            Console.WriteLine("- Cannot use keywords");

            // Correct Way:
            int age = 25;              
            string firstName = "Rohan"; 

            // Wrong Way:
            // int first name = 10;   // spaces cannot be used in variable names
            // int 2age = 10;         // name cannot start with a number
            // int int = 10;          // 'int' is a keyword (reserved word)
            // variable names should be simple, clear, and follow naming rules
        }


        // Constant
        static void Constants()
        {
            // const → fixed value
            const double pi = 3.14159;

            Console.WriteLine("PI: " + pi);

            // pi = 3.14; ❌ not allowed
            // const must be assigned at declaration
            Console.WriteLine("Constant cannot be changed.");
        }

        // Var Keyword
        static void VarKeyword()
        {
            // compiler detects type automatically
            var name = "Rohan";     // string
            var age = 25;           // int
            var salary = 25000.5;   // double
            var isLearning = true;  // bool

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Learning: " + isLearning);

            // var is not dynamic (it does NOT change type later)
            // the type is decided once when the value is assigned

            // Not allowed:
            // var x;        // error → must give a value when using var
            // var y = null; // error → compiler cannot understand the type

            Console.WriteLine("use var when the type is clear from the value");
        }
    }
}