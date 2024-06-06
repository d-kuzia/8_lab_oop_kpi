using System.Collections.Generic;
using System.Linq;

namespace _8_lab_oop_kpi
{
    public class TaskManager
    {
        private List<Task> tasks;

        public TaskManager()
        {
            tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
        }

        public IEnumerable<Task> GetTasks()
        {
            return tasks;
        }

        public IEnumerable<Task> GetTasksByStatus(bool isCompleted)
        {
            return tasks.Where(t => t.IsCompleted == isCompleted);
        }

        public Task GetTaskById(int id)
        {
            return tasks.Find(t => t.Id == id);
        }

        public IEnumerable<Task> GetOverdueTasks()
        {
            return tasks.Where(t => t.IsOverdue());
        }

        public IEnumerable<Task> GetTasksByStatusAndDeadline(bool isCompleted, bool isOverdue)
        {
            return tasks.Where(t => t.IsCompleted == isCompleted && t.IsOverdue() == isOverdue);
        }
    }
}
