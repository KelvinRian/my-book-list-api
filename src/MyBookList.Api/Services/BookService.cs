using MyBookList.Api.Data;

namespace MyBookList.Api.Services
{
    public class BookService : IBookService
    {
        AppDbContext _dbContext;

        public BookService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
