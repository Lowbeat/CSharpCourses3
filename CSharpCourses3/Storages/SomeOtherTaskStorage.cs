namespace CSharpCourses3.Storages;

public class SomeOtherTaskStorage : ITaskStorage
{
    public void AddTask(Task task)
    {
        throw new NotImplementedException();
    }

    public void DeleteTask(int id)
    {
        throw new NotImplementedException();
    }

    public void EditTask(int id, string newDescription)
    {
        throw new NotImplementedException();
    }

    public void CompleteTask(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Task> GetAllTasks()
    {
        throw new NotImplementedException();
    }
}