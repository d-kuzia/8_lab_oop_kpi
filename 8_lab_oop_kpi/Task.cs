using System;

namespace _8_lab_oop_kpi
{
    public class Task : IExecutable
    {
        public int Id {  get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime Deadline { get; set; }
        public TeamMember AssignedMember { get; set; }
        public Task(int id, string description, DateTime deadline)
        {
            Id = id;
            Description = description;
            IsCompleted = false;
            Deadline = deadline;
        }

        public void Execute()
        {
            IsCompleted = true;
        }

        public void AssignTo(TeamMember member)
        {
            AssignedMember = member;
            member.AssignTask(this);
        }

        public void Unassign()
        {
            AssignedMember?.RemoveTask(this);
            AssignedMember = null;
        }

        public void UpdateDescription(string description)
        {
            Description = description;
        }

        public bool IsOverdue()
        {
            return DateTime.Now > Deadline;
        }
    }
}
