namespace TaskManagerApp.Model
{
    public class TaskList
    {
        public int Id {get; set; }
        public string? Title {get; set; }
        public DateTime DueDate {get; set; }= DateTime.Now;
        public string? Description {get; set; }
        public bool IsCompleted {get; set; }
    }
}
