using LibraryManagementSystem.Interface;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.Service
{
    public class BookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Book>> GetAllBooksAsync()
        {
            return _repository.GetAllAsync();
        }

        public Task<Book?> GetBookByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task AddBookAsync(Book book)
        {
            return _repository.AddAsync(book);
        }

        public Task UpdateBookAsync(Book book)
        {
            return _repository.UpdateAsync(book);
        }

        public Task DeleteBookAsync(int id)
        {
            return _repository.DeleteAsync(id);
        }
    }
}