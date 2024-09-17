namespace CSharpCourses3;

public class Task
{
    public int Id { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public override string ToString()
    {
        return $"[Id: {Id}] Description: {Description}, Completed: {IsCompleted}";
    }
}