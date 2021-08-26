using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {

        public List<bookModel> GetAllBooks()
        {
            return Datasource();
        }

        public bookModel GetBookById(int id)
        {
            return Datasource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<bookModel> SearchBook(string title, string AuthorName)
        {
            return Datasource().Where(x => x.Title.Contains(title) || x.Author.Contains(AuthorName)).ToList();
        }

        //Data source

        private List<bookModel> Datasource()
        {
            return new List<bookModel>()
            {
                new bookModel(){Id=1, Title="Jarvis", Author="Tony"},
                new bookModel(){Id=2, Title="Java", Author="tim"},
                new bookModel(){Id=3, Title="python", Author="harry"},
                new bookModel(){Id=4, Title="abc", Author="anonymous"},
            };
        }

    }
}
