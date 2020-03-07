using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    class Company
    {
        //var userEntry = Console.ReadLine();

        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }
        public string Employee { get; set; }
        // Create a private property for holding an array of current employees
        private List<Employee> Employees { get; set; }


        // Create a method that allows a caller to remove an employee
        public void Fired()
        {

        }


        
        // Create a method that allows a caller to add an employee
        public void Hired(DateTime hiredOn, Employee newEmployee)
        {
            Employees.Add(newEmployee);
            
            Console.WriteLine($"You have hired {newEmployee.FirstName} on {hiredOn}.");
        }

        // Create a method that allows a caller to retrieve the list of employees
        public void ListEmployees()
        {
            foreach ( var employee in Employees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
        }


        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime createdOn, Employee firstEmployee)
        {
            Name = name;
            CreatedOn = createdOn;
            Employees = new List<Employee> { firstEmployee};
        }

        
    }
}
