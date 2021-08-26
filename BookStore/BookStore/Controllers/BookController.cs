using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        //Constructor
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

      public List<bookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public bookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<bookModel> SearchBooks(string BookName, string AuthorName)
        {
            return _bookRepository.SearchBook(BookName, AuthorName);
        }
    }
}
