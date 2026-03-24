using Blazor_Exercise.Dto;
using Blazor_Exercise.Model;


namespace Blazor_Exercise.Interface
{
    public interface ITaskService
    {
        Task AddTaskAsync(TaskItemDto task);

        Task<List<TaskItemDto>> GetAllTasksAsync();

        Task CompleteTaskAsync(int id);

        Task DeleteTaskAsync(int id);
    
    }
}