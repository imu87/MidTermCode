using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.Inheritance.Quiz1
{
    internal class EBook:Book
    {
        private string format = "PDF";

        public new void DisplayInfo()
        {
            Console.WriteLine("EBook Information:");
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Pages: " + pages);
            Console.WriteLine("Format: " + format);
        }

    }
}
