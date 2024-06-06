using System;
using System.Text;
using _8_lab_oop_kpi;

namespace TaskSheduler
{
    class Program
    {
        /*static void Main()
        {
            //1.1. Можливість додавати виконавця
            Team team = new Team();
            TeamMember member1 = new TeamMember(1, "Tyson Fury");
            TeamMember member2 = new TeamMember(2, "Sanya Usyk");
            TeamMember member3 = new TeamMember(2, "Tom Cruise");
            TeamMember member4 = new TeamMember(2, "Will Smith");
            team.AddMember(member1);
            team.AddMember(member2);
            team.AddMember(member3);
            team.AddMember(member4);

            //1.2. Можливість видаляти виконавця
            team.RemoveMember(member4);

            //1.3. Можливість змінити дані про виконавця
            member2.UpdateName("Oleksandr Usyk");

            //1.4. Можливість перегляду списку всіх членів команди
            Console.WriteLine("Team Members: ");
            foreach (var member in team.GetMembers())
            {
                Console.WriteLine($"- {member.Name}");
            }

            //2.1. Можливість додавати завдання
            Project project = new Project("New Project");
            _8_lab_oop_kpi.Task task1 = new _8_lab_oop_kpi.Task(1, "First task", DateTime.Now.AddDays(2));
            _8_lab_oop_kpi.Task task2 = new _8_lab_oop_kpi.Task(1, "Second task", DateTime.Now.AddDays(3));
            _8_lab_oop_kpi.Task task3 = new _8_lab_oop_kpi.Task(1, "Second task", DateTime.Now.AddDays(4));
            project.TaskManager.AddTask(task1);
            project.TaskManager.AddTask(task2);
            project.TaskManager.AddTask(task3);

            //2.2. Можливість видаляти завдання
            project.TaskManager.RemoveTask(task3);

            //2.3. Можливість змінювати дані завдання
            task2.UpdateDescription("Updated second task");

            //2.4. Можливість перегляду списку завдань
            Console.WriteLine("Tasks: ");
            foreach (var task in project.TaskManager.GetTasks())
            {
                Console.WriteLine($"- {task.Description} (Completed: {task.IsCompleted})");
            }

            //2.5. Можливість перегляду завдань виконаних невиконаних
            Console.WriteLine("Uncompleted tasks: ");
            foreach (var task in project.TaskManager.GetTasksByStatus(false))
            {
                Console.WriteLine($"- {task.Description}");
            }

            //3.1. Можливість розподілити завдання між виконавцями
            task1.AssignTo(member1);
            task2.AssignTo(member2);

            //3.2. Можливість вказати ступінь виконання, статус виконано не виконано
            task1.Execute();

            //3.3. Можливість перевірки терміну виконання (триває закінчився)
            Console.WriteLine("Overdue Tasks:");
            foreach (var task in project.TaskManager.GetOverdueTasks())
            {
                Console.WriteLine($"- {task.Description} (Deadline: {task.Deadline})");
            }

            //3.4. Можливість перевірки завантаженості виконавців
            Console.WriteLine("Team Members Workload:");
            foreach (var member in team.GetMembers())
            {
                Console.WriteLine($"- {member.Name} has {member.AssignedTasks.Count} tasks");
            }

            //3.5. Можливість отримання стану виконання проекту
            Console.WriteLine("Project completion status: " + (project.IsCompleted() ? "Completed" 
                                                                                     : "Not Completed"));

            //4.1. Можливість пошуку виконавця та його завдань
            var searchMember = team.GetMemberById(1);
            if (searchMember != null)
            {
                Console.WriteLine($"Tasks for {searchMember.Name}:");
                foreach (var task in searchMember.AssignedTasks)
                {
                    Console.WriteLine($"- {task.Description}");
                }
            }

            //4.2. Можливість пошуку виконавців певного завдання
            var searchTask = project.TaskManager.GetTaskById(1);
            if (searchTask != null && searchTask.AssignedMember != null)
            {
                Console.WriteLine($"Task '{searchTask.Description}' is assigned to {searchTask.AssignedMember.Name}");
            }

            //4.3. Можливість пошуку виконаних невиконаних завдань, термін яких сплив триває
            Console.WriteLine("Completed and Overdue tasks:");
            foreach (var task in project.TaskManager.GetTasksByStatusAndDeadline(true, true))
            {
                Console.WriteLine($"- {task.Description} (Deadline: {task.Deadline})");
            }

            Console.WriteLine("Uncompleted and Overdue tasks:");
            foreach (var task in project.TaskManager.GetTasksByStatusAndDeadline(false, true))
            {
                Console.WriteLine($"- {task.Description} (Deadline: {task.Deadline})");
            }

            Console.WriteLine("Uncompleted and Not Overdue tasks:");
            foreach (var task in project.TaskManager.GetTasksByStatusAndDeadline(false, false))
            {
                Console.WriteLine($"- {task.Description} (Deadline: {task.Deadline})");
            }
        }*/
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Team team = new Team();
            Project project = new Project("New Project");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("Оберіть дію:");
                Console.WriteLine("(1) 1.1. Додати виконавця");
                Console.WriteLine("(2) 1.2. Видалити виконавця");
                Console.WriteLine("(3) 1.3. Змінити дані виконавця");
                Console.WriteLine("(4) 1.4. Переглянути список всіх членів команди");
                Console.WriteLine("(5) 2.1. Додати завдання");
                Console.WriteLine("(6) 2.2. Видалити завдання");
                Console.WriteLine("(7) 2.3. Змінити дані завдання");
                Console.WriteLine("(8) 2.4. Переглянути список завдань");
                Console.WriteLine("(9) 2.5. Переглянути виконані/невиконані завдання");
                Console.WriteLine("(10) 3.1. Розподілити завдання між виконавцями");
                Console.WriteLine("(11) 3.2. Вказати статус виконання завдання");
                Console.WriteLine("(12) 3.3. Перевірити термін виконання завдань");
                Console.WriteLine("(13) 3.4. Перевірити завантаженість виконавців");
                Console.WriteLine("(14) 3.5. Отримати стан виконання проекту");
                Console.WriteLine("(15) 4.1. Пошук виконавця та його завдань");
                Console.WriteLine("(16) 4.2. Пошук виконавців певного завдання");
                Console.WriteLine("(17) 4.3. Пошук виконаних/невиконаних завдань за терміном");
                Console.WriteLine("(18) Вихід");
                Console.WriteLine("---------------------------------------------------------------");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddTeamMember(team);
                        break;
                    case "2":
                        RemoveTeamMember(team);
                        break;
                    case "3":
                        UpdateTeamMember(team);
                        break;
                    case "4":
                        DisplayTeamMembers(team);
                        break;
                    case "5":
                        AddTask(project);
                        break;
                    case "6":
                        RemoveTask(project);
                        break;
                    case "7":
                        UpdateTask(project);
                        break;
                    case "8":
                        DisplayTasks(project);
                        break;
                    case "9":
                        DisplayTasksByStatus(project);
                        break;
                    case "10":
                        AssignTaskToMember(project, team);
                        break;
                    case "11":
                        SetTaskCompletionStatus(project);
                        break;
                    case "12":
                        CheckTaskDeadlines(project);
                        break;
                    case "13":
                        CheckMemberWorkload(team);
                        break;
                    case "14":
                        CheckProjectCompletionStatus(project);
                        break;
                    case "15":
                        SearchMemberAndTasks(team);
                        break;
                    case "16":
                        SearchTaskAndAssignee(project);
                        break;
                    case "17":
                        SearchTasksByStatusAndDeadline(project);
                        break;
                    case "18":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }

                static void AddTeamMember(Team team)
                {
                    Console.Write("Введіть ID виконавця: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Введіть ім'я виконавця: ");
                    string name = Console.ReadLine();
                    TeamMember member = new TeamMember(id, name);
                    team.AddMember(member);
                    Console.WriteLine("Виконавець доданий.\n");
                }

                static void RemoveTeamMember(Team team)
                {
                    Console.Write("Введіть ID виконавця для видалення: ");
                    int id = int.Parse(Console.ReadLine());
                    TeamMember member = team.GetMemberById(id);
                    if (member != null)
                    {
                        team.RemoveMember(member);
                        Console.WriteLine("Виконавець видалений.\n");
                    }
                    else
                    {
                        Console.WriteLine("Виконавця з таким ID не знайдено.\n");
                    }
                }

                static void UpdateTeamMember(Team team)
                {
                    Console.Write("Введіть ID виконавця для зміни: ");
                    int id = int.Parse(Console.ReadLine());
                    TeamMember member = team.GetMemberById(id);
                    if (member != null)
                    {
                        Console.Write("Введіть нове ім'я виконавця: ");
                        string newName = Console.ReadLine();
                        member.UpdateName(newName);
                        Console.WriteLine("Ім'я виконавця змінено.\n");
                    }
                    else
                    {
                        Console.WriteLine("Виконавця з таким ID не знайдено.\n");
                    }
                }

                static void DisplayTeamMembers(Team team)
                {
                    Console.WriteLine("Члени команди:");
                    foreach (var member in team.GetMembers())
                    {
                        Console.WriteLine($"- {member.Name}");
                    }
                    Console.WriteLine();
                }

                static void AddTask(Project project)
                {
                    Console.Write("Введіть ID завдання: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Введіть опис завдання: ");
                    string description = Console.ReadLine();
                    Console.Write("Введіть термін виконання завдання (рррр-мм-дд): ");
                    DateTime deadline = DateTime.Parse(Console.ReadLine());
                    _8_lab_oop_kpi.Task task = new _8_lab_oop_kpi.Task(id, description, deadline);
                    project.TaskManager.AddTask(task);
                    Console.WriteLine("Завдання додане.\n");
                }

                static void RemoveTask(Project project)
                {
                    Console.Write("Введіть ID завдання для видалення: ");
                    int id = int.Parse(Console.ReadLine());
                    _8_lab_oop_kpi.Task task = project.TaskManager.GetTaskById(id);
                    if (task != null)
                    {
                        project.TaskManager.RemoveTask(task);
                        Console.WriteLine("Завдання видалене.\n");
                    }
                    else
                    {
                        Console.WriteLine("Завдання з таким ID не знайдено.\n");
                    }
                }

                static void UpdateTask(Project project)
                {
                    Console.Write("Введіть ID завдання для зміни: ");
                    int id = int.Parse(Console.ReadLine());
                    _8_lab_oop_kpi.Task task = project.TaskManager.GetTaskById(id);
                    if (task != null)
                    {
                        Console.Write("Введіть новий опис завдання: ");
                        string newDescription = Console.ReadLine();
                        task.UpdateDescription(newDescription);
                        Console.WriteLine("Опис завдання змінено.\n");
                    }
                    else
                    {
                        Console.WriteLine("Завдання з таким ID не знайдено.\n");
                    }
                }

                static void DisplayTasks(Project project)
                {
                    Console.WriteLine("Завдання:");
                    foreach (var task in project.TaskManager.GetTasks())
                    {
                        Console.WriteLine($"- {task.Description} (Completed: {task.IsCompleted})");
                    }
                    Console.WriteLine();
                }

                static void DisplayTasksByStatus(Project project)
                {
                    Console.WriteLine("Виконані завдання:");
                    foreach (var task in project.TaskManager.GetTasksByStatus(true))
                    {
                        Console.WriteLine($"- {task.Description}");
                    }
                    Console.WriteLine();
                    
                    Console.WriteLine("Невиконані завдання:");
                    foreach (var task in project.TaskManager.GetTasksByStatus(false))
                    {
                        Console.WriteLine($"- {task.Description}");
                    }
                    Console.WriteLine();
                }

                static void AssignTaskToMember(Project project, Team team)
                {
                    Console.Write("Введіть ID завдання для призначення: ");
                    int taskId = int.Parse(Console.ReadLine());
                    _8_lab_oop_kpi.Task task = project.TaskManager.GetTaskById(taskId);
                    if (task != null)
                    {
                        Console.Write("Введіть ID виконавця для призначення: ");
                        int memberId = int.Parse(Console.ReadLine());
                        TeamMember member = team.GetMemberById(memberId);
                        if (member != null)
                        {
                            task.AssignTo(member);
                            Console.WriteLine("Завдання призначено виконавцю.\n");
                        }
                        else
                        {
                            Console.WriteLine("Виконавця з таким ID не знайдено.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Завдання з таким ID не знайдено.\n");
                    }
                }

                static void SetTaskCompletionStatus(Project project)
                {
                    Console.Write("Введіть ID завдання для зміни статусу: ");
                    int taskId = int.Parse(Console.ReadLine());
                    _8_lab_oop_kpi.Task task = project.TaskManager.GetTaskById(taskId);
                    if (task != null)
                    {
                        task.Execute();
                        Console.WriteLine("Завдання позначене як виконане.\n");
                    }
                    else
                    {
                        Console.WriteLine("Завдання з таким ID не знайдено.\n");
                    }
                }

                static void CheckTaskDeadlines(Project project)
                {
                    Console.WriteLine("Просрочені завдання:");
                    foreach (var task in project.TaskManager.GetOverdueTasks())
                    {
                        Console.WriteLine($"- {task.Description} (Deadline: {task.Deadline})");
                    }
                    Console.WriteLine();
                }

                static void CheckMemberWorkload(Team team)
                {
                    Console.WriteLine("Завантаженість виконавців:");
                    foreach (var member in team.GetMembers())
                    {
                        Console.WriteLine($"- {member.Name} має {member.AssignedTasks.Count} завдань");
                    }
                    Console.WriteLine();
                }

                static void CheckProjectCompletionStatus(Project project)
                {
                    Console.WriteLine("Стан виконання проекту: " + (project.IsCompleted() ? "Виконано" 
                                                                                          : "Не виконано"));
                    Console.WriteLine();
                }

                static void SearchMemberAndTasks(Team team)
                {
                    Console.Write("Введіть ID виконавця для пошуку: ");
                    int memberId = int.Parse(Console.ReadLine());
                    TeamMember member = team.GetMemberById(memberId);
                    if (member != null)
                    {
                        Console.WriteLine($"Завдання для {member.Name}:");
                        foreach (var task in member.AssignedTasks)
                        {
                            Console.WriteLine($"- {task.Description}");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Виконавця з таким ID не знайдено.\n");
                    }
                }

                static void SearchTaskAndAssignee(Project project)
                {
                    Console.Write("Введіть ID завдання для пошуку: ");
                    int taskId = int.Parse(Console.ReadLine());
                    _8_lab_oop_kpi.Task task = project.TaskManager.GetTaskById(taskId);
                    if (task != null && task.AssignedMember != null)
                    {
                        Console.WriteLine($"Завдання '{task.Description}' призначене на {task.AssignedMember.Name}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Завдання з таким ID не знайдено або воно не призначене виконавцю.\n");
                    }
                }

                static void SearchTasksByStatusAndDeadline(Project project)
                {
                    Console.WriteLine("Виконані та прострочені завдання:");
                    foreach (var task in project.TaskManager.GetTasksByStatusAndDeadline(true, true))
                    {
                        Console.WriteLine($"- {task.Description} (Deadline: {task.Deadline})");
                    }
                    Console.WriteLine();

                    Console.WriteLine("Невиконані та прострочені завдання:");
                    foreach (var task in project.TaskManager.GetTasksByStatusAndDeadline(false, true))
                    {
                        Console.WriteLine($"- {task.Description} (Deadline: {task.Deadline})");
                    }
                    Console.WriteLine();

                    Console.WriteLine("Невиконані та не прострочені завдання:");
                    foreach (var task in project.TaskManager.GetTasksByStatusAndDeadline(false, false))
                    {
                        Console.WriteLine($"- {task.Description} (Deadline: {task.Deadline})");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}