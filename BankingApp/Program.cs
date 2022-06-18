// See https://aka.ms/new-console-template for more information
using BankingApp;

    var account = new Bankacc("Jackie", 200000);
    Console.WriteLine($"Account {account.Number} was created for {account.Owner} with ${account.Balance}.");
    account.MakeWithdrawal(4000, DateTime.Now, "Guitar");
    Console.WriteLine($"Your new balance is {account.Balance}");
    
    account.MakeDeposit(200, DateTime.Now, "return");
Console.WriteLine(account.getHistory());

