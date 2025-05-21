using System;

class BankAccount
{
    private string accountNumber;
    private double balance;

    public BankAccount(string accountNumber, double initialBalance = 0)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }

        balance += amount;
        Console.WriteLine($"Deposited: {amount}. New Balance: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be positive.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds! Overdraft not allowed.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}. New Balance: {balance}");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current Balance: {balance}");
    }
}
