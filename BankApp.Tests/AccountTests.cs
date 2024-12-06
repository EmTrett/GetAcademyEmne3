using BankApp.Console;

namespace BankApp.Tests;

public class Tests
{
    [Test]
    public void AddNewAccount()
    {
        var user = new Account("John Doe", 0);
        
        var userNameExpected = "John Doe";
        var userNameActual = user.Name;
        
        var balanceExpected = 0;
        var balanceActual = user.Balance;
        
        Assert.That(userNameExpected, Is.EqualTo(userNameActual));
        Assert.That(balanceExpected, Is.EqualTo(balanceActual));
    }

    [Test]
    public void AddMoneyToAccount()
    {
        var user = new Account("John Doe", 10);

        user.AddBalance(15);
        
        var userBalanceExpected = 25;
        var userBalanceActual = user.Balance;
        
        Assert.That(userBalanceExpected, Is.EqualTo(userBalanceActual));
    }

    [Test]
    public void AddMoneyToAccountWithNegativeBalance()
    {
        var user = new Account("John Doe", 10);
        
        user.AddBalance(-15);
        
        var userBalanceExpected = 10;
        var userBalanceActual = user.Balance;
        
        Assert.That(userBalanceExpected, Is.EqualTo(userBalanceActual));
    }

    [Test]
    public void WithdrawMoney()
    {
        var user = new Account("John Doe", 10);

        var cash = user.Withdraw(5);
        
        var cashActual = 5;
        var userBalanceExpected = 5;
        var userBalanceActual = user.Balance;
        
        Assert.That(cash, Is.EqualTo(cashActual));
        Assert.That(userBalanceExpected, Is.EqualTo(userBalanceActual));
    }

    [Test]
    public void WithdrawMoneyWithNotEnoughBalance()
    {
        var user = new Account("John Doe", 10);
        
        var cash = user.Withdraw(15); 
        var cashActual = 0;
        
        var userBalanceExpected = 10;
        var userBalanceActual = user.Balance;
        
        Assert.That(cash, Is.EqualTo(cashActual));
        Assert.That(userBalanceExpected, Is.EqualTo(userBalanceActual));
    }

    [Test]
    public void WithdrawNegativeMoney()
    {
        var user = new Account("John Doe", 10);
        var cash = user.Withdraw(-5);
        
        var cashActual = 0;
        var userBalanceExpected = 10;
        var userBalanceActual = user.Balance;
        
        Assert.That(cash, Is.EqualTo(cashActual));
        Assert.That(userBalanceExpected, Is.EqualTo(userBalanceActual));
    }
}