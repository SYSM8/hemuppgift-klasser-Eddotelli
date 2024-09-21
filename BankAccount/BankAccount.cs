using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        //Lägg till Egenskaper (fields)
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        //Lägg till Konstruktor
        public BankAccount(string accountNumber, string accountHolder, double balance) 
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance; 
        }

        //Lägg till Metoder
        public void Deposit(double newDeposit)
        {
            Balance += newDeposit;
            Console.WriteLine($"Deposited: {newDeposit}, New Balance: {Balance}\n");
        }

        public void Withdraw(double newWhitdraw)
        {
            Balance -= newWhitdraw;

            Console.WriteLine($"Whitdraw: {newWhitdraw}, New Balance: {Balance}\n");
        }

        public void DisplayBalance() 
        {
            Console.WriteLine($"Balance: {Balance}");
        }

        //Lycka till! :)
    }
}
