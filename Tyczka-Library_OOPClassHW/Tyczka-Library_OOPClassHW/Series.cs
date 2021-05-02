using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyczka_Library_OOPClassHW
{
    enum taylors_version_of_Genre
    {
        CrazedTeenGirl,
        AdventureScienceFiction,
        Military,
        SchoolRequirements
    }
    class Series
    {
        public string SeriesTitle;
        public taylors_version_of_Genre thistaylors_Version_Of_Genre;
        public Author thisAuthor;
        
        public Series()
        {
            Console.WriteLine("Series added.");
        }
    }
}
