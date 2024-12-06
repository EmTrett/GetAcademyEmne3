namespace BankApp.Console;

public class Account(string name, int balance = 0)
{
    public string Name { get; } = name;
    public int Balance { get; private set; } = balance;

    public void AddBalance(int moneyIn)
    {
        if (moneyIn < 0) return;
        Balance += moneyIn;
    }

    public int Withdraw(int requestedWithdrawAmount)
    {
        if (requestedWithdrawAmount < 0) return 0;
        if (requestedWithdrawAmount > Balance)
        {
            System.Console.WriteLine($"You cannot withdraw {requestedWithdrawAmount}, balance not sufficient.");
            return 0;
        }
        Balance -= requestedWithdrawAmount;
        
        return requestedWithdrawAmount;
    }
}