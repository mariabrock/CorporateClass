using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    class Employee
    {

        public string Occupation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(string firstName, string lastName, string occupation)
        {
            FirstName = firstName;
            LastName = lastName;
            Occupation = occupation;
        }

        

    }
}
