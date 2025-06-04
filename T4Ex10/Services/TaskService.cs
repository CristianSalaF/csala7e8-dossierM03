using T4Ex10.Models;

namespace T4Ex10.Services
{
    public class TaskService
    {
        private static List<TaskItem> _tasks = new List<TaskItem>();
        private static int _nextId = 1;

        public List<TaskItem> GetAllTasks()
        {
            return _tasks;
        }

        public void AddTask(TaskItem task)
        {
            task.Id = _nextId++;
            _tasks.Add(task);
        }

        public void ToggleTaskCompleted(int taskId)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == taskId);
            if (task != null)
            {
                task.IsCompleted = !task.IsCompleted;
            }
        }

        public int GetTotalTasks()
        {
            return _tasks.Count;
        }

        public int GetCompletedTasks()
        {
            return _tasks.Count(t => t.IsCompleted);
        }

        public int GetPendingTasks()
        {
            return _tasks.Count(t => !t.IsCompleted);
        }
    }
}
