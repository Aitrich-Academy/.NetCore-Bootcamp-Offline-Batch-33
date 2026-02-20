using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services
{
    public class BookService : IBookService
    {
        public readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public async Task<List<Books>> GetAllBooksAsync()
        {
            return await bookRepository.GetAllBooksAsync();
        }

        public async Task<Books> GetBookByIdAsync(int id)
        {
            return await bookRepository.GetBookByIdAsync(id);
        }

        public async Task CreateBookAsync(Books book)
        {
            await bookRepository.CreateBookAsync(book);
        }

        public async Task UpdateBookAsync(Books book)
        {
            await bookRepository.UpdateBookAsync(book);
        }

        public async Task DeleteBookAsync(int id)
        {
            await bookRepository.DeleteBookAsync(id);
        }
    }
}
