using LibraryManagementSystem.Data;
using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Repositories
{
    public class BookRepository : IBookRepository
    {
        public readonly AppDbContext context;
        public BookRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Books>> GetAllBooksAsync()
        {
            return await context.Books.ToListAsync();
        }

        public async Task<Books> GetBookByIdAsync(int id)
        {
            return await context.Books.FindAsync(id);
        }

        public async Task UpdateBookAsync(Books book)
        {
            context.Books.Update(book);
            await context.SaveChangesAsync();
        }

        public async Task CreateBookAsync(Books book)
        {
            await context.Books.AddAsync(book);
            await context.SaveChangesAsync();
        }
        public async Task DeleteBookAsync(int id)
        {
            var book = await context.Books.FindAsync(id);
            if (book != null)
            {
                context.Books.Remove(book);
                await context.SaveChangesAsync();
            }
        }
    }
}
