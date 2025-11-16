using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.Inheritance.Quiz1
{
    internal class Book
    {
        private string title = "C# Basics";
        protected string author = "John Smith";
        internal int pages = 300;

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Book Title: " + title);
            Console.WriteLine("Author: " + author);
        }

    }
}
