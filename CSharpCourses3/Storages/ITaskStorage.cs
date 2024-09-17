namespace CSharpCourses3.Storages;

public interface ITaskStorage
{
    void AddTask(Task task);
    void DeleteTask(int id);
    void EditTask(int id, string newDescription);
    void CompleteTask(int id);
    IEnumerable<Task> GetAllTasks();
}
