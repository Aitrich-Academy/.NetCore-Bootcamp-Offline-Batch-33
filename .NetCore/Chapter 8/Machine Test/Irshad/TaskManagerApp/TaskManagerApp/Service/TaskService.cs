using TaskManagerApp.Interface;
using TaskManagerApp.Model;

namespace TaskManagerApp.Service
{
    public class TaskService : ITaskService
    {
        private readonly List<TaskList> _tasks = new List<TaskList>();
        private int id = 1;
        public async Task<List<TaskList>> GetAllTasksAsync()
        {
            return await Task.FromResult(_tasks);
        }
        public async Task AddTaskAsync(TaskList task)
        {
            task.Id = id++;
            _tasks.Add(task);
            await Task.CompletedTask;
        }
        public async Task DeleteTaskAsync(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                _tasks.Remove(task);
            }
            await Task.CompletedTask;
        }
        public async Task MarkComplete(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = true;
            }
            await Task.CompletedTask;
        }
    }
}
