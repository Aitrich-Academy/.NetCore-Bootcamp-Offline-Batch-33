using TaskManagerApp.Model;

namespace TaskManagerApp.Interface
{
    public interface ITaskService
    {
        public Task<List<TaskList>> GetAllTasksAsync();
        public Task AddTaskAsync(TaskList task);
        public Task DeleteTaskAsync(int id);
        public Task MarkComplete(int id);
    }
}
