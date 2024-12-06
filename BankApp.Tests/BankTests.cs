using BankApp.Console;

namespace BankApp.Tests;

public class BankTests
{
    [Test]
    public void AddAccountsToBank()
    {
        Bank DnB = new Bank();
        
        DnB.AddAccount("John", 10);
        
        var AccountName = DnB.Accounts[0].Name;
        var AccountBalance = DnB.Accounts[0].Balance;
        
        var expectedAccountName = "John";
        var expectedAccountBalance = 10;
        
        Assert.That(AccountBalance, Is.EqualTo(expectedAccountBalance));
        Assert.That(AccountName, Is.EqualTo(expectedAccountName));
    }

    [Test]
    public void AddToAccountBalance()
    {
        Bank DnB = new Bank();
        
        DnB.AddAccount("John", 10);

        DnB.AddBalanceToAccout("John", 30);
    }

    [Test]
    public void GetAccountBalance()
    {
        Bank DnB = new Bank();
        
        DnB.AddAccount("John", 10);
        
        int balance = DnB.GetAccountBalance("John");
        
        Assert.That(balance, Is.EqualTo(10));
    }

    [Test]
    public void TransferBetweenAccounts()
    {
        Bank DnB = new Bank();
        DnB.AddAccount("John", 10);
        DnB.AddAccount("Frank", 30);
        
        DnB.Transfer("John", "Frank", 10);
        
        var johnBalanceExpected = 0;
        var frankBalanceExpected = 40;
        var johnBalanceActual = DnB.GetAccountBalance("John");
        var frankBalanceActual = DnB.GetAccountBalance("Frank");
        
        Assert.That(johnBalanceExpected, Is.EqualTo(johnBalanceActual));
        Assert.That(frankBalanceExpected, Is.EqualTo(frankBalanceActual));
    }

    [Test]
    public void TransferWithInvalidBalance()
    {
        Bank DnB = new Bank();
        DnB.AddAccount("John", 0);
        DnB.AddAccount("Frank", 30);
        
        DnB.Transfer("John", "Frank", 10);
        
        var johnBalanceExpected = 0;
        var frankBalanceExpected = 30;
        var johnBalanceActual = DnB.GetAccountBalance("John");
        var frankBalanceActual = DnB.GetAccountBalance("Frank");
        
        Assert.That(johnBalanceExpected, Is.EqualTo(johnBalanceActual));
        Assert.That(frankBalanceExpected, Is.EqualTo(frankBalanceActual));
    }

    [Test]
    public void TransferWithInvalidAccountName()
    {
        Bank DnB = new Bank();
        
        DnB.AddAccount("John", 10);
        DnB.AddAccount("Frank", 30);
        
        DnB.Transfer("John", "Pubert", 10);
        
        var johnBalanceExpected = 10;
        var frankBalanceExpected = 30;
        
        var johnBalanceActual = DnB.GetAccountBalance("John");
        var frankBalanceActual = DnB.GetAccountBalance("Frank");
        
        Assert.That(johnBalanceExpected, Is.EqualTo(johnBalanceActual));
        Assert.That(frankBalanceExpected, Is.EqualTo(frankBalanceActual));
    }
}