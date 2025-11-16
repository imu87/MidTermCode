using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.Inheritance.Quiz1
{
    internal class LibraryApp
    {
        static void Main(string[] args)
        {
            EBook ebook = new EBook();
            ebook.DisplayInfo();

            Book bookRef = new EBook(); //mane ovverride hole object onujai call hobe r override na hole reference onujai
                                        // Book bookRef = new EBook() -> Book is reference and new EBook is object
            bookRef.DisplayInfo();
        }

    }
}
