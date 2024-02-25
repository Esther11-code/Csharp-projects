using System;
using System.Text;

namespace consoleApp
{
	public class BankingSystem
	{
        class BankAccount
        {
            public string AccountNumber { get; }
            public string Owner { get; }
            public decimal Balance
            {
                get
                {
                    decimal balance = 0;
                    foreach (var item in allTransactions)
                    {
                        balance += item.Amount;
                    }
                    return balance;
                }
            }

            private static int accountNumberSeed = 1234567890;

            private List<Transaction> allTransactions = new List<Transaction>();

            public BankAccount(string name, decimal initialBalance)
            {
                this.Owner = name;
                this.AccountNumber = accountNumberSeed.ToString();
                accountNumberSeed++;

                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
            }

            public void MakeDeposit(decimal amount, DateTime date, string note)
            {
                if (amount <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
                }
                var deposit = new Transaction(amount, date, note);
                allTransactions.Add(deposit);
            }

            public void MakeWithdrawal(decimal amount, DateTime date, string note)
            {
                if (amount <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
                }
                if (Balance - amount < 0)
                {
                    throw new InvalidOperationException("Not sufficient funds for this withdrawal");
                }
                var withdrawal = new Transaction(-amount, date, note);
                allTransactions.Add(withdrawal);
            }

            public string GetAccountHistory()
            {
                var report = new StringBuilder();

                report.AppendLine("Date\t\tAmount\tNote");
                foreach (var item in allTransactions)
                {
                    report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
                }

                return report.ToString();
            }
        }

        class Transaction
        {
            public decimal Amount { get; }
            public DateTime Date { get; }
            public string Notes { get; }

            public Transaction(decimal amount, DateTime date, string note)
            {
                this.Amount = amount;
                this.Date = date;
                this.Notes = note;
            }
        }

        class Program
        {
            static void Main()
            {
                var account = new BankAccount("John Doe", 1000);
                Console.WriteLine($"Account {account.AccountNumber} was created for {account.Owner} with initial balance of {account.Balance}");

                account.MakeDeposit(500, DateTime.Now, "Salary");
                Console.WriteLine($"Balance after salary deposit: {account.Balance}");

                account.MakeWithdrawal(200, DateTime.Now, "Groceries");
                Console.WriteLine($"Balance after grocery withdrawal: {account.Balance}");

                Console.WriteLine();
                Console.WriteLine(account.GetAccountHistory());
            }
        }

    }
}


