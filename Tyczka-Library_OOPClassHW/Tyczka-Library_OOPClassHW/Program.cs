using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyczka_Library_OOPClassHW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create book, author, series

            // Twlight Stephenie Meyer The Twilight Saga
            Author sm = new Author();
            sm.FName = "Stephenie";
            sm.Lname = "Meyer";
            Book bk1 = new Book();
            bk1.Author = sm;
            bk1.BookTitle = "Twilight";
            Series ts = new Series();
            ts.SeriesTitle = "The Twilight Saga";
            ts.thistaylors_Version_Of_Genre = taylors_version_of_Genre.CrazedTeenGirl;
            ts.thisAuthor = sm;

            //City of Bones Cassandra Clare The Mortal Instruments
            Author cc = new Author();
          cc.FName = "Cassandra";
           cc.Lname = "Clare";
            Book bk2 = new Book();
            bk2.Author = cc;
            bk2.BookTitle = "City of Bones";
            Series tmi = new Series();
            tmi.SeriesTitle = "The Mortal Instruments";
            tmi.thistaylors_Version_Of_Genre = taylors_version_of_Genre.AdventureScienceFiction;
            tmi.thisAuthor = cc;

            //To Kill a Mocking Bird  Harper Lee To Kill a Mocking Bird Series
            Author hl = new Author();
            hl.FName = "Harper";
            hl.Lname = "Lee";
            Book bk3 = new Book();
            bk3.Author = hl;
            bk3.BookTitle = "To Kill a Mocking Bird";
            Series tkmbs = new Series();
            tkmbs.SeriesTitle = "To Kill a Mocking Bird Series";
            tkmbs.thistaylors_Version_Of_Genre = taylors_version_of_Genre.SchoolRequirements;
            tkmbs.thisAuthor = hl;
            Console.ReadLine();


        }
    }
}
