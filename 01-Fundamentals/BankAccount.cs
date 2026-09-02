using System;

namespace _01_Fundamentals;

class Account
{
    public string AccountHolder { get; private set; }

    public decimal Balance { get; private set; }

    public Account(string accountHolder, decimal balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Enter a valid positive deposit amount");
            return;
        }

        Balance += amount;
        Console.WriteLine($"Your updated balance is {Balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Enter a positive withdrawal amount");
            return;
        }

        if (amount > Balance)
        {
            Console.WriteLine($"Withdrawal failed. Your current balance is {Balance}");
            return;
        }

        Balance -= amount;

        Console.WriteLine(
            $"The amount you withdrew was {amount}\n" +
            $"Your remaining balance is {Balance}"
        );
    }

    public void ShowBalance()
    {
        Console.WriteLine(
            $"Your current bank balance for account holder {AccountHolder} is: {Balance}"
        );
    }
}

class BankAccount
{
    public static void Run()
    {
        // creating a new account
        Account ac1 = new Account("Yugansh", 50000);

        // printing initial balance
        ac1.ShowBalance();

        // depositing some money
        ac1.Deposit(6900);
        ac1.ShowBalance();

        // withdrawing money
        ac1.Withdraw(100);
        ac1.ShowBalance();

        // testing withdrawal greater than available balance
        ac1.Withdraw(60000);
    }
}