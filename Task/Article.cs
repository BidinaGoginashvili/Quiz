using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Article : Gamocema<Article>
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public string magazineName { get; set; }
        public int ReleaseDate { get; set; }
        public int amountOfPages { get; set; }

        public override List<Article> DisplayInformation(List<Article> Information)
        {
            Console.WriteLine("The information about article");
            foreach (var item in Information)
            {
                Console.WriteLine("Title: {0};" + Environment.NewLine +"Magazine Name{1}" + Environment.NewLine + " AuthorName: {2};" + Environment.NewLine + " PublisherName:{3};" + Environment.NewLine + "ReleaseDate: {4}" + Environment.NewLine, item.Title,item.magazineName ,item.AuthorName, item.PublisherName, item.ReleaseDate);
            }
            return Information;
        }

        public override List<Article> SearchByYear(List<Article> Information, int year)
        {
            foreach (var item in Information.Where(x => x.ReleaseDate == year))
            {
                Console.WriteLine("Title: {0};" + Environment.NewLine + "Magazine Name{1}" + Environment.NewLine + " AuthorName: {2};" + Environment.NewLine + " PublisherName:{3};" + Environment.NewLine + "ReleaseDate: {4}" + Environment.NewLine, item.Title, item.magazineName, item.AuthorName, item.PublisherName, item.ReleaseDate);
            }
            return Information;
        }
    }
}
