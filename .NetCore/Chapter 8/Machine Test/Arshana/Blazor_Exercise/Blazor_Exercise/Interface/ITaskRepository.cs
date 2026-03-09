using Blazor_Exercise.Model;


namespace Blazor_Exercise.Interface
{
    public interface ITaskRepository
    {
        Task<List<TaskItem>> GetTasksAsync();

        Task AddTaskAsync(TaskItem task);

        Task DeleteTaskAsync(int id);

        Task MarkCompleteAsync(int id);
    }
}