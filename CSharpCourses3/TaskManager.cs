using CSharpCourses3.Storages;

namespace CSharpCourses3;

public class TaskManager
{
    private readonly ITaskStorage _taskStorage;

    public TaskManager(ITaskStorage taskStorage)
    {
        _taskStorage = taskStorage;
    }

    public void AddTask(string description)
    {
        _taskStorage.AddTask(new Task { Description = description });
    }

    public void DeleteTask(int id)
    {
        _taskStorage.DeleteTask(id);
    }

    public void EditTask(int id, string newDescription)
    {
        _taskStorage.EditTask(id, newDescription);
    }

    public void CompleteTask(int id)
    {
        _taskStorage.CompleteTask(id);
    }

    public void ShowTasks()
    {
        var tasks = _taskStorage.GetAllTasks().ToList();
        if(tasks.Any())
        {
            Console.WriteLine(string.Join("\n", tasks));
        }
    }
    
    public bool CheckForIncompleteTasks()
    {
        return _taskStorage.GetAllTasks().Any(x => x.IsCompleted == false);
    }
}
