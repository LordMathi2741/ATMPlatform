using InversionDependencies.InversionLayer.Interfaces;

namespace InversionDependencies.InversionLayer.AccountFactory;

public class AccountFactory : IAccount
{
    public void CreateAccount(List<Account>bankAccount, int amount)
    {
        bankAccount.Add(new Account(amount));
    }
    
}