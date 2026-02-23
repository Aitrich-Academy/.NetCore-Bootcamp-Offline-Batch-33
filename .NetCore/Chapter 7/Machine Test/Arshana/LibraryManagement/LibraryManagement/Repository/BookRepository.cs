using LibraryManagementSystem.Data;
using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _db;

        public BookRepository(AppDbContext db)
        {
            _db = db;
        }

        public Task<List<Book>> GetAllAsync()
            => _db.Books.AsNoTracking().OrderBy(b => b.Id).ToListAsync();

        public Task<int> CountAsync()
            => _db.Books.CountAsync();

        public async Task AddAsync(Book book)
            => await _db.Books.AddAsync(book);

        public Task<Book?> GetByIdAsync(int id)
            => _db.Books.FirstOrDefaultAsync(b => b.Id == id);

        public Task DeleteAsync(Book book)
        {
            _db.Books.Remove(book);
            return Task.CompletedTask;
        }

        public Task SaveChangesAsync()
            => _db.SaveChangesAsync();
    }
}