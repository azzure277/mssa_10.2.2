using System;
using System.Collections.Generic;
using System.Linq;

namespace mssa_10._2._2
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee { Name = "Alice", Age = 25, Salary = 6000 },
                new Employee { Name = "Bob", Age = 32, Salary = 7000 },
                new Employee { Name = "Charlie", Age = 28, Salary = 5500 },
                new Employee { Name = "Diana", Age = 29, Salary = 4800 },
                new Employee { Name = "Eve", Age = 27, Salary = 5100 }
            };

            var filtered = employees.Where(e => e.Salary > 5000 && e.Age < 30);

            Console.WriteLine("Employees with salary > $5000 and age < 30:");
            foreach (var emp in filtered)
            {
                Console.WriteLine($"Name: {emp.Name}, Age: {emp.Age}, Salary: ${emp.Salary}");
            }
        }
    }
}
