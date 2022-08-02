namespace SolidPrinciples;

// The Interface Segregation Principle(ISP) states that a
// class must not have to implement any interface element that is not required by the particular class.
public interface ILead
{  
    void CreateSubTask();  
    void AssignTask();  
    void WorkOnTask();
}
public class TeamLead : ILead
{
    public void AssignTask()
    {
        Console.WriteLine($"Lead assigns a task");
        //Code to assign a task.  
    }
    public void CreateSubTask()
    {
        Console.WriteLine($"Lead creates a sub task");
        //Code to create a sub task  
    }

    public void WorkOnTask()
    {
        Console.WriteLine($"Lead works on a sub task");
        //Code to implement perform assigned task.  
    }
}


public class Manager : ILead
{
    public void AssignTask()
    {
        //Code to assign a task.  
    }
    public void CreateSubTask()
    {
        //Code to create a sub task.  
    }
    public void WorkOnTask()
    {
        throw new Exception("Manager can't work on Task");
    }
}