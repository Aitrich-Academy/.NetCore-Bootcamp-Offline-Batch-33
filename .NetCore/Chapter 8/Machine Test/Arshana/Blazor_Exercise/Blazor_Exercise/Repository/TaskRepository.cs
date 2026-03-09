using System.Collections.Generic;
using Blazor_Exercise.Interface;
using Blazor_Exercise.Model;


namespace Blazor_Exercise.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly List<TaskItem> tasks = new();
        private int nextId = 1;

        public Task<List<TaskItem>> GetTasksAsync()
        {
            return Task.FromResult(tasks);
        }

        public Task AddTaskAsync(TaskItem task)
        {
            task.Id = nextId++;
            task.IsCompleted = false;

            tasks.Add(task);

            return Task.CompletedTask;
        }

        public Task DeleteTaskAsync(int id)
        {
            var task = tasks.FirstOrDefault(x => x.Id == id);

            if (task != null)
                tasks.Remove(task);

            return Task.CompletedTask;
        }

        public Task MarkCompleteAsync(int id)
        {
            var task = tasks.FirstOrDefault(x => x.Id == id);

            if (task != null)
                task.IsCompleted = true;

            return Task.CompletedTask;
        }
    }
}