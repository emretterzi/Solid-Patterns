// Cooling interface
public interface ICooler
{
    void ApplyCoolingProcess();
}

// Cooling module
public class CoolingModule : ICooler
{
    public void ApplyCoolingProcess()
    {
        Console.WriteLine("Applying cooling process...");
    }
}

// High-level module
public class HighLevelModule
{
    private ICooler cooler;  // Dependency

    public HighLevelModule(ICooler cooler)
    {
        this.cooler = cooler;
    }

    public void Run()
    {
        cooler.ApplyCoolingProcess();
    }
}

// Usage
public class Program
{
    public static void Main()
    {
        ICooler cooler = new CoolingModule();
        HighLevelModule highLevelModule = new HighLevelModule(cooler);
        highLevelModule.Run();
    }
}
