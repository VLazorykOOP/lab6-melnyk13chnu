namespace pro100user.task2;

//Реактивний двигун
public class JetEngineImpl : DieselEngineImpl
{
    public JetEngineImpl()
    {
        Console.WriteLine("Constructor \"JetEngineImpl\"");
    }
    
    public JetEngineImpl(string name) : base(name)
    {
        Console.WriteLine("Constructor \"JetEngineImpl\"");
    }
    
    public JetEngineImpl(string name, string power) : base(name, power)
    {
        Console.WriteLine("Constructor \"JetEngineImpl\"");
    }
    
    ~JetEngineImpl()
    {
        Console.WriteLine("Destructor \"JetEngineImpl\"");
    }
    
    public override void Show()
    {
        Console.WriteLine($"JetEngineImpl \"{name}\" <- DieselEngineImpl <- InternalCombustionEngineImpl <- EngineImpl");
    }
}