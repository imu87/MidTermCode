using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.Inheritance
{
    public class Student:Person  // so basically student inherits person class
    {
        public String id;
        public double CGPA;
        public float hight;

         public void Display2()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("CGPA:  " + CGPA);
            Console.WriteLine("Hight: " + hight);

        }

    }
}
