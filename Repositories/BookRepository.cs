using LibraryAPI.Configurations;
using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DbContextConfiguration _context;
        private int response;
        public BookRepository(DbContextConfiguration context)
        {
            _context = context;
        }

        public async Task AddBookAsync(Book book)
        {
            
               _context.Add(book);
               await _context.SaveChangesAsync();
           
        }

        public async Task DeleteBookAsync(Book book)
        {
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _context.Books.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateBookAsync(Book book)
        {
                _context.Books.Update(book);
                await _context.SaveChangesAsync();
        }
    }
}
