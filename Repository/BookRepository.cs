

using BookServiceApi.Models;

namespace BookServiceApi.Repository
{
    public class BookRepository : IBookRepository
    {

        public static List<Book> books = new List<Book>() { new Book { BookId = 1, BookName = "Alchemist", Price = 400, Author="pauelo", Lang="English", Publisher="Harper", ReleaseYear=2000 } };
      

        //addbook
        public void AddBook(Book book)
        {
            try
            {
                books.Add(book);
            }
            catch(Exception)
            {
                throw;
            }
        }

        //Getallbooks
        public List<Book> GetAllBooks()
        {
            try
            {
                return books;

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Getbooksbyauthor
        public List<Book> GetBooksByAuthor(string author)
        {
            try
            {
                List<Book> bookswithauthor = new List<Book>();
                foreach (var book in books)
                {
                    if (book.Author == author)
                        bookswithauthor.Add(book);
                }
                return bookswithauthor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //GetbOOKSBYlang
        public List<Book> GetBooksByLang(string lang)
        {
            try
            {
                List<Book> bookswithlang = new List<Book>();
                foreach (var book in books)
                {
                    if (book.Lang == lang)

                        bookswithlang.Add(book);
                }

                return bookswithlang;

            }
            catch (Exception)
            {
                throw;
            }
        }
        //getbookby name
        public Book GetBooksByName(string Name)
        {
            try
            {
                foreach (var book in books)
                {
                    if (book.BookName == Name)
                        return book;
                }

                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //getbookbyid

        public Book GetBooksById(int id)
        {
            try
            {
                foreach (var book in books)
                {
                    if (book.BookId == id)
                        return book;
                }

                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }



        //getbooks by year

        public List<Book> GetBooksByYear(int Year)
        {
            try
            {
                List<Book> bookswithYear = new List<Book>();
                foreach(var book in books)
                {
                    if (book.ReleaseYear == Year)
                        bookswithYear.Add(book);
                }
                return bookswithYear;
            }
            catch(Exception)
            {

                throw;
            }

        }


        //editbook

        public void EditBook(Book book)
        {
            try
            {
                foreach(var item in books)
                {
                    if(item.BookId == book.BookId)
                    {
                        item.BookName = book.BookName;
                        item.Author = book.Author;
                        item.Lang = book.Lang;
                        item.ReleaseYear = book.ReleaseYear;
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

      


        //deletebook
        public void DeleteBook(int id)
        {
            try
            {
                foreach (var item in books)
                {
                    if(item.BookId == id)
                    {
                        books.Remove(item);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            {

            }
        }

       
        
        

       
    }

}
