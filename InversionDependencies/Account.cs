namespace InversionDependencies;

public class Account
{
    private int amount;
    
    public Account(int amount)
    {
        this.amount = amount;
    }

    public int GetAmount()
    {
        return this.amount;
    }

    public void SetAmount(int _amount)
    {
        this.amount = _amount;
    }

    
    
}