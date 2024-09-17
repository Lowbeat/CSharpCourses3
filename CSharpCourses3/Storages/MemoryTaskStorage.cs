namespace CSharpCourses3.Storages;

public class MemoryTaskStorage : ITaskStorage
{
    private List<Task> _tasks = new List<Task>();
    private int _currentId = 1;

    public void AddTask(Task task)
    {
        task.Id = _currentId++;
        _tasks.Add(task);
    }

    public void DeleteTask(int id)
    {
        _tasks.RemoveAll(t => t.Id == id);
    }

    public void EditTask(int id, string newDescription)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            task.Description = newDescription;
        }
        else
        {
            Console.WriteLine("No task found!");
        }
    }

    public void CompleteTask(int id)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            task.IsCompleted = true;
        }
        else
        {
            Console.WriteLine("No task found!");
        }
    }

    public IEnumerable<Task> GetAllTasks()
    {
        return _tasks;
    }
}
