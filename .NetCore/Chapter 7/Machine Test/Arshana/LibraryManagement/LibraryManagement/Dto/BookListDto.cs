namespace LibraryManagementSystem.DTOs
{
    public class BookListDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int Quantity { get; set; }
    }
}