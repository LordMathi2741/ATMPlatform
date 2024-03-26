namespace InversionDependencies.ServiceLayer.Services;

public static class Transaction
{
    public static void Sell(Account bankAccount, int quantity)
    {
       bankAccount.SetAmount(bankAccount.GetAmount() - quantity);

    }
    

}