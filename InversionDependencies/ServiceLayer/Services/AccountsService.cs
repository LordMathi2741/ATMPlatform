namespace InversionDependencies.ServiceLayer.Services;

public static class AccountsService
{
    public static  void GetAmountByAccount(Account account)
    {
        Console.WriteLine(account.GetAmount());
    }
}