using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Interfaces
{
    public interface IBookService
    {
        public Task<List<Books>> GetAllBooksAsync();
        public Task<Books> GetBookByIdAsync(int id);
        public Task CreateBookAsync(Books book);
        public Task UpdateBookAsync(Books book);
        public Task DeleteBookAsync(int id);
    }
}
