using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.Inheritance.Quiz1
{
    public class Employee
    {
        private String id;
        private String name;


        public Employee(String ID, String Name)
        {
            id = ID;
            name = Name;
        }

        public void Display1()
        {
            Console.WriteLine("ID: " + id);

            Console.WriteLine("Name: " + name);
            
        }
    }
}
