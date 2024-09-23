using LibraryAPI.Models;

namespace LibraryAPI.Repositories
{
    public interface IBookRepository
    {
        public Task<List<Book>> GetAllBooksAsync();
        public Task<Book> GetBookByIdAsync(int id);
        public Task AddBookAsync(Book book);
        public Task UpdateBookAsync(Book book);
        public Task DeleteBookAsync(Book book);
    }
}
