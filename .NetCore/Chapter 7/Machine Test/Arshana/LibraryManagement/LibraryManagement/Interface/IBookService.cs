using LibraryManagementSystem.DTOs;

namespace LibraryManagementSystem.Interfaces
{
    public interface IBookService
    {
        Task<List<BookListDto>> GetBooksAsync();
        Task<int> GetTotalBookCountAsync();

        Task AddBookAsync(BookCreateDto dto);
        Task<bool> DeleteBookAsync(int id);
    }
}