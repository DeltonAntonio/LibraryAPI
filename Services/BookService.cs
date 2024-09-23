using LibraryAPI.DTOs;
using LibraryAPI.Models;
using LibraryAPI.Repositories;

namespace LibraryAPI.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository repository;
        public BookService(IBookRepository repository) { 
            this.repository = repository;
        }
        public async Task AddBook(Book book)
        {
           await repository.AddBookAsync(book);
        }

        public async Task DeleteBook(Book book)
        {
            await repository.DeleteBookAsync(book);
        }

        public async Task<BookDTO> GetBook(int id)
        {
            var book = await repository.GetBookByIdAsync(id);
            
            var bookDTO = new BookDTO
            {
                Title = book.Title,
                Description = book.Description,
                Author = book.Author,
                Image = book.Image,
            };

            return bookDTO;
        }

        public async Task<List<BookDTO>> GetBooks()
        {
            var books = await repository.GetAllBooksAsync();

            var booksDTOs = books.Select(e => new BookDTO { 
                Title = e.Title,
                Description = e.Description,
                Author = e.Author,
                Image = e.Image,

            }).ToList();

            return booksDTOs;
        }

        public async Task UpdateBook(Book book)
        {
            await repository.UpdateBookAsync(book);
        }
    }
}
