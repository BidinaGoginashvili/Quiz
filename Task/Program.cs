using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            List<Book> bookList = new List<Book>() {
                  new Book { Title = "Harry Potter", AuthorName = "J.K Rowling", amountOfPages = 1234, PublisherName = "Nick Davidson", ReleaseDate = 1999 },
                  new Book { Title = "Lord Of The Rings", AuthorName = "J.R.R Tolkien", amountOfPages = 1120, PublisherName = "Braum Williams", ReleaseDate = 2000 }
            };

            Article article = new Article();
            List<Article> articleList = new List<Article>() {
                  new Article { Title = "Tavis Movlis Sashualebebi",AuthorName = "Nino Toronjadze", magazineName = "Tbiliselebi", amountOfPages = 34, PublisherName = "Babilina", ReleaseDate = 2019 },
                  new Article { Title = "Ivanishvilis Koneba", AuthorName = "Tina Lekiashvili", magazineName="Palitra",amountOfPages = 1120, PublisherName = "Braum Williams", ReleaseDate = 2000 }
            };
            book.DisplayInformation(bookList);
            article.DisplayInformation(articleList);

            Console.WriteLine("Filter Books By Year,Input Year...");
            int inputBookYear = Convert.ToInt32(Console.ReadLine());
            book.SearchByYear(bookList, inputBookYear);

            Console.WriteLine("Filter Article By Year,Input Year...");
            int inputArticleYear = Convert.ToInt32(Console.ReadLine());
            article.SearchByYear(articleList, inputArticleYear);
            Console.ReadLine();
        }
    }
}
