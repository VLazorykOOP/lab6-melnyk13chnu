namespace pro100user.task2;

//Двигун внутрішнього згорання
public class InternalCombustionEngineImpl : InternalCombustionEngine
{
    protected String name;
    
    public InternalCombustionEngineImpl()
    {
        name = "someInternalCombustionEngine";
        Console.WriteLine("Constructor \"InternalCombustionEngineImpl\"");
    }
    
    public InternalCombustionEngineImpl(string name)
    {
        this.name = name;
        Console.WriteLine("Constructor \"InternalCombustionEngineImpl\"");
    }
    
    public InternalCombustionEngineImpl(string name, string power)
    {
        this.name = name + " " + power;
        Console.WriteLine("Constructor \"InternalCombustionEngineImpl\"");
    }
    
    ~InternalCombustionEngineImpl()
    {
        Console.WriteLine("Destructor \"InternalCombustionEngineImpl\"");
    }
    
    public virtual void Show()
    {
        Console.WriteLine($"InternalCombustionEngineImpl \"{name}\" <- EngineImpl");
    }

    public void Burn()
    {
        Console.WriteLine("Burn");
    }
}