using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Interfaces
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllAsync();
        Task<int> CountAsync();
        Task AddAsync(Book book);
        Task<Book?> GetByIdAsync(int id);
        Task DeleteAsync(Book book);
        Task SaveChangesAsync();
    }
}