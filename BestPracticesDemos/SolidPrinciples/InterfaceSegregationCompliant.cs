namespace SolidPrinciples;

public interface IProgrammer
{
    void WorkOnTask();
}

public interface ILeadC
{
    void AssignTask();
    void CreateSubTask();
}

public class Programmer : IProgrammer
{
    public void WorkOnTask()
    {
        Console.WriteLine($"Programmer works on a sub task");
    }
}
public class ManagerC : ILeadC
{
    public void AssignTask()
    {
        Console.WriteLine($"Manager assigns a task");
        //Code to assign a Task  
    }
    public void CreateSubTask()
    {
        Console.WriteLine($"Manager creates a sub task");
        //Code to create a sub task from a task.  
    }
}

public class TeamLeadC : IProgrammer, ILeadC
{
    public void AssignTask()
    {
        Console.WriteLine($"Lead assigns a task");
        //Code to assign a Task  
    }
    public void CreateSubTask()
    {
        Console.WriteLine($"Lead creates a sub task");
        //Code to create a sub task from a task.  
    }
    public void WorkOnTask()
    {
        Console.WriteLine($"Lead works on a task");
        //code to implement to work on the Task.  
    }
}