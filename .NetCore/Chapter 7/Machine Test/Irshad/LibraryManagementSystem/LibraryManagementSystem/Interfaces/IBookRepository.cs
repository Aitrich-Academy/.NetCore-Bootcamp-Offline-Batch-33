namespace LibraryManagementSystem.Interfaces
{
    public interface IBookRepository
    {
        public Task<List<Models.Books>> GetAllBooksAsync();
        public Task<Models.Books> GetBookByIdAsync(int id);
        public Task CreateBookAsync(Models.Books book);
        public Task UpdateBookAsync(Models.Books book);
        public Task DeleteBookAsync(int id);
    }
}
