using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapAdapter
{
    internal class PersonInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PersonInfo(string name , string lastname ) 
        {
            FirstName = name;
            LastName = lastname;
        }
    }
}
