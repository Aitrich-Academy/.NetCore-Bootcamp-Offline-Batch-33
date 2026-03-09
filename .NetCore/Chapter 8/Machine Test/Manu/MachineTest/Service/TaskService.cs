using MachineTest.Model;
using MachineTest.Repository;

namespace MachineTest.Service
{
    public class TaskServices
    {
        private readonly TaskRepository _taskRepository;

        public TaskServices(TaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<List<TaskItem>> GetAllTasksAsync()
        {
            return await _taskRepository.GetAllTasksAsync();
        }

        public async Task AddTaskAsync(TaskItem task)
        {
            await _taskRepository.AddAsync(task);
        }

        public async Task UpdateTaskAsync(TaskItem task)
        {
            await _taskRepository.UpdateAsync(task);
        }

        public async Task DeleteTaskAsync(int id)
        {
            await _taskRepository.DeleteAsync(id);
        }

        public async Task StatusAsync(int id)
        {
            await _taskRepository.StatusAsync(id);
        }
    }
}