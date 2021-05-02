using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyczka_Library_OOPClassHW
{
    class Book
    {
        private string _bookTitle;
       
        private Author _author;
        private Series _series;

        public string BookTitle { get => _bookTitle; set => _bookTitle = value; }
       
       internal Author Author { get => _author; set => _author = value; }
        internal Series Section { get => _series; set => _series = value; }

        public Book()
        {
            Console.WriteLine("Book added.");
        }
    }
}
