using LibraryAPI.DTOs;
using LibraryAPI.Models;

namespace LibraryAPI.Services
{
    public interface IBookService
    {
        public Task<List<BookDTO>> GetBooks();
        public Task<BookDTO> GetBook(int id);
        public Task AddBook(Book book);
        public Task DeleteBook(Book book);
        public Task UpdateBook (Book book);

    }
}
