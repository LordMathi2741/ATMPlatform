namespace InversionDependencies.ServiceLayer.Services;

public static class Accounts
{
    public static  void GetAmountByAccount(Account account)
    {
        Console.WriteLine(account.GetAmount());
    }
}