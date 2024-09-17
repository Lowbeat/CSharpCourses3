namespace CSharpCourses3;

public class CommandHandler
{
    private readonly TaskManager _taskManager;

    public CommandHandler(TaskManager taskManager)
    {
        _taskManager = taskManager;
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Select a command:");
            Console.WriteLine("1. Add a new task.");
            Console.WriteLine("2. Edit an existing task.");
            Console.WriteLine("3. Delete a task.");
            Console.WriteLine("4. Complete a task.");
            Console.WriteLine("5. List of all tasks.");
            Console.WriteLine("6. Exit.");
            
            switch (Console.ReadLine())
            {
                case "1":
                {
                    Console.Write("Enter task description: ");
                    var description = Console.ReadLine();
                    _taskManager.AddTask(description);
                    break;
                }

                case "2":
                {
                    Console.Write("Enter task id to edit: ");
                    var idToEdit = int.Parse(Console.ReadLine());
                    Console.Write("Enter new description: ");
                    var newDescription = Console.ReadLine();
                    _taskManager.EditTask(idToEdit, newDescription);
                    break;
                }

                case "3":
                {
                    Console.Write("Enter task id to delete: ");
                    var idToDelete = int.Parse(Console.ReadLine());
                    _taskManager.DeleteTask(idToDelete);
                    break;
                }

                case "4":
                {
                    Console.Write("Enter task id to complete: ");
                    var idToComplete = int.Parse(Console.ReadLine());
                    _taskManager.CompleteTask(idToComplete);
                    break;
                }

                case "5":
                {
                    _taskManager.ShowTasks();
                    break;
                }

                case "6":
                {
                    if (_taskManager.CheckForIncompleteTasks())
                    {
                        Console.WriteLine("Exit prohibited! There are incomplete tasks.");
                        break;
                    }
                    else
                    {
                        return;
                    }
                }

                default:
                {
                    Console.WriteLine("Invalid command.");
                    break;
                }
            }
        }
    }
}
