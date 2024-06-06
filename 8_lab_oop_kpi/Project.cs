namespace _8_lab_oop_kpi
{
    public class Project
    {
        public string Name { get; set; }
        public TaskManager TaskManager { get; set; }

        public Project(string name)
        {
            Name = name;
            TaskManager = new TaskManager();
        }

        public bool IsCompleted()
        {
            foreach (var task in TaskManager.GetTasks())
            {
                if (!task.IsCompleted)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
