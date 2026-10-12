// Importing System namespace to use built-in things like Console
using System;

// Namespace → helps organize code and avoid naming conflicts
namespace _01_Basics
{
    // 'public' means this class can be accessed from outside this file/project
    // 'static' means we do not need to create an object to use this class
    // 'class' is like a container that holds methods
    public static class Basics
    {
        // 'void' means this method does not return any value
        // 'Run' is the starting method for this file
        public static void Run()
        {
            ShowIntroduction();
            ShowSyntaxRules();
            ShowOutputExamples();
            ShowCommentsExample();
        }

        // Introduction
        static void ShowIntroduction()
        {
            Console.WriteLine("C# is a programming language developed by Microsoft.");
            Console.WriteLine("It runs on the .NET platform.");
            Console.WriteLine("Used for web, desktop, APIs, games, etc.");
        }

        // Syntax Rules
        static void ShowSyntaxRules()
        {
            string myName = "Rohan"; // variable

            Console.WriteLine("C# is case-sensitive.");
            Console.WriteLine("Example variable: " + myName);

            // Statement ends with semicolon
            Console.WriteLine("Statements usually end with ;");
            Console.WriteLine();
        }

        // Output Examples
        static void ShowOutputExamples()
        {
            // WriteLine → prints and goes to new line
            Console.WriteLine("Hello World!");

            // Write → stays on same line
            Console.Write("Hello ");
            Console.Write("World");
            Console.WriteLine();

            // Printing numbers
            Console.WriteLine(3 + 3);
            Console.WriteLine();
        }

        // Comments
        static void ShowCommentsExample()
        {
            // Single-line comment

            /*
               Multi-line comment
               used for explanation
            */

            Console.WriteLine("Comments help explain code.");
        }
    }
}