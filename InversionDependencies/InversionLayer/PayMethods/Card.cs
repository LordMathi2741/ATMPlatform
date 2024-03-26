namespace InversionDependencies.InversionLayer.PayMethods;

public class Card: IPayMethods
{

    public void PayWithMethod()
    {
        Console.WriteLine("Paying with Card ");
    }
    
}