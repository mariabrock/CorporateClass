using System;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that allows a caller to add an employee
            Employee steve = new Employee("Steve", "Bob", "Plumber");

            Employee bill = new Employee("Bill", "Rob", "Driver");

            Company Abcd = new Company("Abcd", DateTime.Today, steve);

            Abcd.Hired(DateTime.Today, bill);
            Abcd.ListEmployees();

            Console.ReadKey();
        }
    }
}
