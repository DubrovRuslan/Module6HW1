using Microsoft.AspNetCore.Mvc;
using Module6HW1.Items;
using Module6HW1.Services.Interfaces;

namespace Module6HW1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManageController : Controller
    {
        private readonly ILogger<ManageController> _logger;

        private readonly IDataBase _db;

        public ManageController(ILogger<ManageController> logger, IDataBase db)
        {
            _db = db;
            _logger = logger;
        }

        [HttpGet]
        [Route("/Books")]
        public IEnumerable<Book> GetAll()
        {
            return _db.GetBooks();
        }

        [HttpGet]
        [Route("/Book/{id}")]
        public Book GetById([FromRoute] int id)
        {
            return _db.GetBook(id);
        }

        [HttpPost]
        [Route("/CreateBook")]
        public void Post(Book Book)
        {
            _db.AddToList(Book);
        }

        [HttpPatch]
        [Route("/UpdateBook")]
        public void Put(Book Book)
        {
            _db.UpdateBook(Book, Book.Id);
        }

        [HttpDelete]
        [Route("/DeleteBook")]
        public void Delete(Book Book)
        {
            _db.DeleteBookById(Book.Id);
        }
    }
}
