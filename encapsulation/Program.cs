using System;

namespace MyApp {
    class Program {
        static void Main(string[] args) {
            BankAccount account = new BankAccount("1234567", 1000);

            Console.WriteLine($"Account Number : {account.AccountNumber}. Balance : {account.Balance}");

            account.Balance = -1000;
        }
    }

    class BankAccount {
        private string accountNumber;
        private int balance;

        public BankAccount(string accountNumber, int balance) {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public string AccountNumber {
            get {
                return this.accountNumber;
            }

            set {
                if(string.IsNullOrEmpty(value)) {
                    Console.WriteLine("Account Number cannot be null or empty");
                } else {
                    this.accountNumber = value;
                }
            }
        }

        public int Balance {
            get {
                return this.balance;
            }

            set {
                if(value < 0) {
                    Console.WriteLine("Balance cannot be negative");
                } else {
                    this.balance = value;
                }
            }
        }
    }
}