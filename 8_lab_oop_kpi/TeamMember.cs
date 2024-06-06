using System.Collections.Generic;

namespace _8_lab_oop_kpi
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Task> AssignedTasks { get; set; }

        public TeamMember(int id, string name)
        {
            Id = id;
            Name = name;
            AssignedTasks = new List<Task>();
        }

        public void AssignTask(Task task)
        { 
            AssignedTasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            AssignedTasks.Remove(task);
        }

        public void UpdateName(string newName)
        {
            Name = newName;
        }
    }
}
