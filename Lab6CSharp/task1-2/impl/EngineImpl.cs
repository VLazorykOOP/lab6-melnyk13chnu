namespace pro100user.task2;

//Двигун
public class EngineImpl : Engine
{
    protected string name;
    
    public EngineImpl()
    {
        name = "someengine";
        Console.WriteLine("Constructor \"EngineImpl\"");
    }
    
    public EngineImpl(string name)
    {
        this.name = name;
        Console.WriteLine("Constructor \"EngineImpl\"");
    }
    
    public EngineImpl(string name, string power)
    {
        this.name = name + " " + power;
        Console.WriteLine("Constructor \"EngineImpl\"");
    }
    
    ~EngineImpl()
    {
        Console.WriteLine("Destructor \"EngineImpl\"");
    }

    public void Show()
    {
        Console.WriteLine($"EngineImpl \"{name}\"");
    }
}