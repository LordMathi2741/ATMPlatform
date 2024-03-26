namespace InversionDependencies.InversionLayer.PayMethods;

public class Crypto : IPayMethods
{
    public void PayWithMethod()
    {
        Console.WriteLine("Paying with crypto");
    }
    
}