using BookServiceApi.Models;
using BookServiceApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository bookRepository;

        public BookController() 
        { 

            bookRepository = new BookRepository();
        }

        [HttpPost,Route("Add Books")]

        public IActionResult AddBook(Book book)
        {
            try
            {
                bookRepository.AddBook(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }




        [HttpGet, Route("GetAll Books")]

        public IActionResult GetAllBooks()
        {
            try
            {
                List<Book> books = bookRepository.GetAllBooks();
                return StatusCode(200, books);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }



        [HttpGet, Route("GetBooks ByAuthor/{Author}")]

        public IActionResult GetBooksByAuthor(string Author)
        {
            try
            {
                return StatusCode(200, bookRepository.GetBooksByAuthor(Author));
            }
            catch (Exception ex) 
                {
                    return StatusCode(501, ex);
                } 
        }

        [HttpGet, Route("GetBooksByLanguage/{Lang}")]

        public IActionResult GetBooksByLang(string Lang)
        {
            try
            {
                return StatusCode(200, bookRepository.GetBooksByLang(Lang));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }


        [HttpGet, Route("GetBookByName")]

        public IActionResult GetBooksByName(string Name)
        {
            try
            {
                Book book = bookRepository.GetBooksByName(Name);
                if (book != null)
                {
                    return StatusCode(200, book);
                }
                else
                {
                    return StatusCode(404, new JsonResult("Invalid Book Name"));
                }
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpGet, Route("GetBookById/{id}")]

        public IActionResult GetBooksById(int id)
        {
            try
            {
                Book book = bookRepository.GetBooksById(id);
                if (book != null)
                {
                    return StatusCode(200, book);
                }
                else
                {
                    return StatusCode(404, new JsonResult("Invalid Book Id"));
                }
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }



        [HttpGet, Route("GetBooksByYear/{ReleaseYear}")]

        public IActionResult GetBooksByYear(int ReleaseYear)
        {
            try
            {
                return StatusCode(200, bookRepository.GetBooksByYear(ReleaseYear));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }

        [HttpPut, Route("EditBook")]

        public IActionResult EditBook(Book book)
        {
            try
            {
               bookRepository.EditBook(book);
                return StatusCode(200, book);

            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }



        [HttpDelete, Route("DeleteBook/{id}")]

        public IActionResult DeleteBook(int id)
        {
            try
            {
                bookRepository.DeleteBook(id);
                return StatusCode(200, "Book Deleted");

            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }

        }




    }
}
