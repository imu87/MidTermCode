using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.Inheritance.Quiz1
{
     public class Manager:Employee
    {
       private String department;// variable

        public String Department // property
        {
            get { return department; }
            set { department = value; }
        }

        public Manager(String ID, String Name, String Department):base(ID,Name) 
        {
            department = Department; // by this way we can call parent
                                     // constractor to child constractor
        }

        public void Display2()
        {
            Display1();
            Console.WriteLine("Departent: " + department);
        }
    }
}
