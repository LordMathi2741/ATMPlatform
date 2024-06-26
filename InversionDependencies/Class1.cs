﻿using InversionDependencies.InversionLayer.AccountFactory;
using InversionDependencies.InversionLayer.PayMethods;
using InversionDependencies.ServiceLayer.Services;

namespace InversionDependencies;

public class Class1
{
    public static void Main()
    {
        List<Account> accountsCreated = [];
        var accountsProcess= new AccountFactory();
        
       accountsProcess.CreateAccount(accountsCreated, 100);
       accountsProcess.CreateAccount(accountsCreated, 200);
       
       TransactionService.Retire(accountsCreated[0],30);
       AccountsService.GetAmountByAccount(accountsCreated[0]);

    }
}