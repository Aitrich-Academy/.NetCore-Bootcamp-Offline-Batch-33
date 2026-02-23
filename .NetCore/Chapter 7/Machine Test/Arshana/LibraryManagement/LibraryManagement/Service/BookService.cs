using LibraryManagementSystem.DTOs;
using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repo;

        public BookService(IBookRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<BookListDto>> GetBooksAsync()
        {
            var books = await _repo.GetAllAsync();
            return books.Select(b => new BookListDto
            {
                Id = b.Id,
                Title = b.Title,
                Author = b.Author,
                Quantity = b.Quantity
            }).ToList();
        }

        public Task<int> GetTotalBookCountAsync()
            => _repo.CountAsync();

        public async Task AddBookAsync(BookCreateDto dto)
        {
            var book = new Book
            {
                Title = dto.Title.Trim(),
                Author = dto.Author.Trim(),
                Quantity = dto.Quantity
            };

            await _repo.AddAsync(book);
            await _repo.SaveChangesAsync();
        }

        public async Task<bool> DeleteBookAsync(int id)
        {
            var book = await _repo.GetByIdAsync(id);
            if (book == null) return false;

            await _repo.DeleteAsync(book);
            await _repo.SaveChangesAsync();
            return true;
        }
    }
}