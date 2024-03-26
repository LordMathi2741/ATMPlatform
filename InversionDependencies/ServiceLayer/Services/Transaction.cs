namespace InversionDependencies.ServiceLayer.Services;

public static class Transaction
{
    public static void Retire(Account bankAccount, int quantity)
    {
       bankAccount.SetAmount(bankAccount.GetAmount() - quantity);

    }

    public static void Load(Account bankAccount, int quantity)
    {
        bankAccount.SetAmount(bankAccount.GetAmount() + quantity);
    }
    

}