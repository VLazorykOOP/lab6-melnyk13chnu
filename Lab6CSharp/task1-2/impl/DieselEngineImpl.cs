namespace pro100user.task2;

//Дизильний двигун
public class DieselEngineImpl : InternalCombustionEngineImpl
{
    public DieselEngineImpl()
    {
        Console.WriteLine("Constructor \"DieselEngineImpl\"");
    }
    
    public DieselEngineImpl(string name) : base(name)
    {
        Console.WriteLine("Constructor \"DieselEngineImpl\"");
    }
    
    public DieselEngineImpl(string name, string power) : base(name, power)
    {
        Console.WriteLine("Constructor \"DieselEngineImpl\"");
    }
    
    ~DieselEngineImpl()
    {
        Console.WriteLine("Destructor \"DieselEngineImpl\"");
    }
    
    public override void Show()
    {
        Console.WriteLine($"DieselEngineImpl \"{name}\" <- InternalCombustionEngineImpl <- EngineImpl");
    }
}