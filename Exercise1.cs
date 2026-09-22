using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpExercises
{
    class Student
    {
        public string Name { get; set; }
        public double Grade { get; set; }

        public Student(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }

        public bool IsPassed()
        {
            return Grade >= 4.0; 
        }
    }

    class Program
    {
        static void CheckAgeCategory()
        {
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age < 0) Console.WriteLine("Invalid age!");
                else if (age < 18) Console.WriteLine("Category: Minor / Student");
                else if (age <= 65) Console.WriteLine("Category: Adult / Worker");
                else Console.WriteLine("Category: Senior");
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid number!");
            }
        }

        static void ProcessNumberList()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter 5 integers:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int val))
                {
                    numbers.Add(val);
                }
            }

            if (numbers.Count > 0)
            {
                Console.WriteLine($"\nSum: {numbers.Sum()}");
                Console.WriteLine($"Average: {numbers.Average():F2}");
                Console.WriteLine($"Max value: {numbers.Max()}");
                Console.WriteLine($"Min value: {numbers.Min()}");
                
                var evenNumbers = numbers.Where(n => n % 2 == 0);
                Console.WriteLine($"Even numbers: {string.Join(", ", evenNumbers)}");
            }
        }

        static void DemoOOP()
        {
            List<Student> students = new List<Student>
            {
                new Student("Alex", 7.5),
                new Student("Bogdan", 8.2),
                new Student("Janis", 3.5)
            };

            Console.WriteLine("\n--- Student Results ---");
            foreach (var student in students)
            {
                string status = student.IsPassed() ? "PASSED" : "FAILED";
                Console.WriteLine($"{student.Name} - Grade: {student.Grade} [{status}]");
            }
        }

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n=================== C# FUNDAMENTALS ===================");
                Console.WriteLine("1. Check Age Category (Conditions & TryParse)");
                Console.WriteLine("2. Process Numbers (List & LINQ operations)");
                Console.WriteLine("3. Student OOP Demo (Classes & Objects)");
                Console.WriteLine("0. Exit");
                Console.WriteLine("=======================================================");
                Console.Write("Choose an option (0-3): ");

                string choice = Console.ReadLine();
                Console.WriteLine("-------------------------------------------------------");

                switch (choice)
                {
                    case "1":
                        CheckAgeCategory();
                        break;
                    case "2":
                        ProcessNumberList();
                        break;
                    case "3":
                        DemoOOP();
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("Exiting application. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}