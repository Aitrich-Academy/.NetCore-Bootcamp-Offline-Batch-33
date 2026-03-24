using Blazor_Exercise.Dto;
using Blazor_Exercise.Interface;

namespace Blazor_Exercise.Service
{
    public class TaskService : ITaskService
    {
        private static List<TaskItemDto> tasks = new();
        public Task AddTaskAsync(TaskItemDto task)
        {
            task.Id = tasks.Count + 1;
            tasks.Add(task);
            return Task.CompletedTask;
        }
        public Task<List<TaskItemDto>> GetAllTasksAsync()
        {
            return Task.FromResult(tasks);
        }
        public Task CompleteTaskAsync(int id)
        {
            var task = tasks.FirstOrDefault(x => x.Id == id);

            if (task != null)
            {
                task.IsCompleted = true;
            }

            return Task.CompletedTask;
        }

        public Task DeleteTaskAsync(int id)
        {
            var task = tasks.FirstOrDefault(x => x.Id == id);

            if (task != null)
            {
                tasks.Remove(task);
            }

            return Task.CompletedTask;
        }
    }
}