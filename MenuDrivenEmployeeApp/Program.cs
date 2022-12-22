using System;
using System.Collections.Generic;

namespace MenuDrivenEmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store the employee details
            List<Employee> employees = new List<Employee>();

            // Initialize a string variable to store the user input
            string input = "";

            // Keep looping until the user enters "quit"
            while (!input.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                // Prompt the user to enter the name of the employee
                Console.WriteLine("Enter the name of the employee:");
                string name = Console.ReadLine();

                // If the user enters "quit", break out of the loop
                if (name.Equals("quit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                // Prompt the user to enter the salary of the employee
                Console.WriteLine("Enter the salary of the employee:");
                double salary = double.Parse(Console.ReadLine());

                // Prompt the user to enter the department of the employee
                Console.WriteLine("Enter the department of the employee:");
                string department = Console.ReadLine();

                // Create a new Employee object using the input provided by the user
                // and add it to the list
                employees.Add(new Employee(name, salary, department));

                // If the list has reached a size of 5, break out of the loop
                if (employees.Count == 5)
                {
                    break;
                }
            }

            // Print the details of all the employees in the list
            Console.WriteLine("Employee Details:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }

    // This class represents an employee with a name, salary, and department
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        // Constructor to initialize the employee object with the given name, salary, and department
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }

        // Overridden ToString method to return a string representation of the employee object
        public override string ToString()
        {
            return $"Employee{{ name='{Name}', salary={Salary}, department='{Department}' }}";
        }
    }
}
