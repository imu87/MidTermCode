using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.Inheritance
{
    public class Person
    {
        public String name;
        public int age;
        public String address;


        public void Display1()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);

        }

    }
}
