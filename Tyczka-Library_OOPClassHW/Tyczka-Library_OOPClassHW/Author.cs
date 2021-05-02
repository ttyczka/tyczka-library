using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyczka_Library_OOPClassHW
{
    class Author
    {
        private string _fName;
        private string _lname;

        public string FName { get => _fName; set => _fName = value; }
        public string Lname { get => _lname; set => _lname = value; }

        public Author()
        {
            Console.WriteLine("Author added.");
        }
    }
}
