using LibraryAPI.DTOs;
using LibraryAPI.Models;
using LibraryAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public readonly IBookService service;
        public BookController(IBookService service) {
            this.service = service;
        }
        [HttpGet]
        public async Task<ActionResult<List<BookDTO>>> GetAllBooks()
        {
            var response = await service.GetBooks();

            return response ==null ? NotFound() : Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookDTO>> GetBookById(int id)
        {
            var response = await service.GetBook(id);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<List<Book>>> AddBook(Book book)
        {
            await service.AddBook(book);

            return CreatedAtAction(nameof(AddBook), book);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteBook(Book book)
        {
            await service.DeleteBook(book);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateBook(int id, Book book) {
            if(id != book.Id)
            {
                return NotFound();
            }
            await service.UpdateBook(book);
            return NoContent();
        }
    }
}
