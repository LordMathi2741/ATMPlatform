namespace InversionDependencies.InversionLayer.PayMethods;

public class Cash:IPayMethods
{
    public void PayWithMethod()
    {
        Console.WriteLine("Paying with cash");
    }
    
}