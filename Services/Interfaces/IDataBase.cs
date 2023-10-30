using Module6HW1.Items;

namespace Module6HW1.Services.Interfaces
{
    public interface IDataBase
    {
        void AddToList(Book Book);
        List<Book> GetBooks();
        void DeleteBookById(int id);
        Book UpdateBook(Book Book, int id);
        Book GetBook(int id);
    }
}
