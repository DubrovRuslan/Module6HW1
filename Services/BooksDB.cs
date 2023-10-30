using Module6HW1.Items;
using Module6HW1.Services.Interfaces;

namespace Module6HW1.Services
{
    public class BooksDB : IDataBase
    {
        private static List<Book> _listBook;

        public BooksDB()
        {
            _listBook = new List<Book>();
        }

        public void AddToList(Book Book)
        {
            _listBook.Add(Book);
        }

        public List<Book> GetBooks()
        {
            return _listBook;
        }

        public void DeleteBookById(int id)
        {
            _listBook.RemoveAt(id - 1);
        }

        public Book UpdateBook(Book Book, int id)
        {
            var s = _listBook.Where(x => x.Id == id).FirstOrDefault();
            _listBook[_listBook.IndexOf(s)] = Book;
            return Book;
        }

        public Book GetBook(int id)
        {
            return _listBook.Where(i => i.Id == id).FirstOrDefault();
        }
    }
}
