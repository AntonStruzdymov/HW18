using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18Library
{
    public class Person
    {
        public string Name { get; set; }
        public string CarName { get; set; }

        public Person (string name, string carname)
        {
            Name = name; 
            CarName = carname; 
        }
    }
}
