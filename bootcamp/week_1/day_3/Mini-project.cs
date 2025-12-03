
using System;
using System.Collections.Generic;
//part1

public class Account
{
    public string AccountNumber;
    public int PIN;
    public double Balance;
    public List<string> Transactions;
    public Account(string accNum, int pin, double initialBalance)
    {
        this.AccountNumber = accNum;
        this.PIN = pin;
        this.Balance = initialBalance;
        this.Transactions = new List<string>();
        this.Transactions.Add($"Account opened with balance: ${initialBalance}");
    }

    // Method: Check Balance
    public void CheckBalance()
    {
        Console.WriteLine($"Current Balance: ${this.Balance}");
    }

    // Method: Deposit
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            this.Balance += amount;
            string trans = $"Deposited: ${amount}";
            this.Transactions.Add(trans);
            Console.WriteLine("Deposit successful!");
        }
        else
        {
            Console.WriteLine("Invalid amount. Must be positive.");
        }
    }

    // Method: Withdraw
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= this.Balance)
        {
            this.Balance -= amount;
            string trans = $"Withdrew: ${amount}";
            this.Transactions.Add(trans);
            Console.WriteLine("Withdrawal successful!");
        }
        else if (amount > this.Balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            Console.WriteLine("Invalid amount.");
        }
    }

    public void ShowTransactions()
    {
        Console.WriteLine("Transaction History:");
        foreach (string transaction in this.Transactions)
        {
            Console.WriteLine(transaction);
        }
    }
}

//partie2: ATM Class

public class ATM
{
    public Account Authenticate(Dictionary<string, Account> accounts)
    {
        Console.Write("Please enter your account number: ");
        string accNum = Console.ReadLine();

        Console.Write("Enter your PIN: ");
        if (int.TryParse(Console.ReadLine(), out int pin))
        {
            if (accounts.ContainsKey(accNum) && accounts[accNum].PIN == pin)
            {
                Console.WriteLine("Authentication successful!\n");
                return accounts[accNum];
            }
        }
        
        Console.WriteLine("Invalid Account Number or PIN.");
        return null;
    }

    public void ShowMenu()
    {
        Console.WriteLine("ATM Menu:");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit Money");
        Console.WriteLine("3. Withdraw Money");
        Console.WriteLine("4. Show Transactions");
        Console.WriteLine("5. Exit");
        Console.Write("Select an option: ");
    }

    public void PerformAction(Account account, string choice)
    {
        switch (choice)
        {
            case "1":
                account.CheckBalance();
                break;
            case "2":
                Console.Write("Enter deposit amount: ");
                double depAmount = double.Parse(Console.ReadLine());
                account.Deposit(depAmount);
                break;
            case "3":
                Console.Write("Enter withdrawal amount: ");
                double withAmount = double.Parse(Console.ReadLine());
                account.Withdraw(withAmount);
                break;
            case "4":
                account.ShowTransactions();
                break;
            case "5":
                Console.WriteLine("Thank you for using our ATM.");
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }
}

// part3: Program Flow

class Program
{
    static void Main()
    {
        Dictionary<string, Account> bankAccounts = new Dictionary<string, Account>();

        Account acc1 = new Account("12345", 6789, 1000.00);
        Account acc2 = new Account("98765", 1234, 500.50);

        bankAccounts.Add(acc1.AccountNumber, acc1);
        bankAccounts.Add(acc2.AccountNumber, acc2);

        ATM atm = new ATM();
        Console.WriteLine("Welcome to the ATM Machine!");

        {
            Account currentAccount = atm.Authenticate(bankAccounts);

            if (currentAccount != null)
            {
                string userChoice = "";
                
                while (userChoice != "5")
                {
                    atm.ShowMenu();
                    userChoice = Console.ReadLine();
                    atm.PerformAction(currentAccount, userChoice);
                }
            }
            else
            {
                Console.WriteLine("Try again? (y/n)");
                string retry = Console.ReadLine();
                if (retry.ToLower() != "y")
                {
                }
            }
        }
    }
}