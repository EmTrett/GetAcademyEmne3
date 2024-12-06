namespace BankApp.Console;

public class Bank
{
    public List<Account> Accounts = [];

    public void AddAccount(string accountName, int balance)
    {
        Accounts.Add(new Account(accountName, balance));
    }

    public void AddBalanceToAccout(string accountName, int amount)
    {
        Accounts.FirstOrDefault(a => a.Name == accountName)!.AddBalance(amount);
    }

    public int GetAccountBalance(string accountName)
    {
        return Accounts.FirstOrDefault(a => a.Name == accountName)!.Balance;
    }

    public void Transfer(string fromAccountName, string toAccountName, int amount)
    {
        var fromAccount = Accounts.FirstOrDefault(a => a.Name == fromAccountName);
        var toAccount = Accounts.FirstOrDefault(a => a.Name == toAccountName);
        if (fromAccount == null || toAccount == null) return;
        var moneyToTransfer = fromAccount.Withdraw(amount);
        if (moneyToTransfer == 0)return;
        toAccount.AddBalance(moneyToTransfer);
    }

    private Account? FindAccount(string fromAccountName)
    {
        return Accounts.FirstOrDefault(a => a.Name == fromAccountName);
    }
}