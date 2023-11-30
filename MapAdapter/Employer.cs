using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapAdapter
{
    internal class Employer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployerId { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Employer: {FirstName} {LastName}, Employee ID: {EmployerId}");
        }
        public Employer(string name , string lastname , string id) 
        {
            FirstName = name;
            LastName = lastname;
            EmployerId = id;
        }
    }
}
