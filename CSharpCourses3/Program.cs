using CSharpCourses3.Storages;

namespace CSharpCourses3;

class Program
{
    static void Main(string[] args)
    {
        ITaskStorage storage = new MemoryTaskStorage(); // Or new FileTaskStorage, SomeOtherTaskStorage etc.
        var taskManager = new TaskManager(storage);
        new CommandHandler(taskManager).Run();
    }
}