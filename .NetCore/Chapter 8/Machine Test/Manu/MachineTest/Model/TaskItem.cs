namespace MachineTest.Model
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateOnly DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}
