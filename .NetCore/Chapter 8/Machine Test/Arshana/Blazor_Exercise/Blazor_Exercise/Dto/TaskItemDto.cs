namespace Blazor_Exercise.Dto
{
    public class TaskItemDto
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }
    }
}
