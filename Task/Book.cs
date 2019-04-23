using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;

namespace Task
{
    class Book : Gamocema<Book>
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public int ReleaseDate { get; set; }
        public int amountOfPages { get; set; }

       

        public override List<Book> DisplayInformation(List<Book> Information)
        {
            Console.WriteLine("The information about book.");
            foreach(var item in Information)
            {
                Console.WriteLine("Title: {0};"+Environment.NewLine+ " AuthorName: {1};" + Environment.NewLine + " PublisherName:{2};" + Environment.NewLine + "ReleaseDate: {3}" + Environment.NewLine, item.Title,item.AuthorName,item.PublisherName,item.ReleaseDate);
            }
            return Information;
        }

        public override List<Book> SearchByYear(List<Book> Information, int year)
        {
            foreach (var item in Information.Where(x=>x.ReleaseDate == year))
            {
                Console.WriteLine("Title: {0};" + Environment.NewLine + " AuthorName: {1};" + Environment.NewLine + " PublisherName:{2};" + Environment.NewLine + "ReleaseDate: {3}" + Environment.NewLine, item.Title, item.AuthorName, item.PublisherName, item.ReleaseDate);
            }
            return Information;
        }
    }
}
