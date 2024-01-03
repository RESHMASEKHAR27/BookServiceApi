using BookServiceApi.Models;

namespace BookServiceApi.Repository
{
    public interface IBookRepository
    {
        void AddBook(Book book);

        List<Book> GetAllBooks();

        List<Book> GetBooksByAuthor(string Author);

        List<Book> GetBooksByLang(string Language);

       Book GetBooksByName(string Name);
       
       Book GetBooksById(int id);

        List<Book> GetBooksByYear(int Year);

        void EditBook(Book book);

        void DeleteBook(int id);




    }
}
