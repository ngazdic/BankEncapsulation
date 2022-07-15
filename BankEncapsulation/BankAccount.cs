using System;
namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
        }

        private double balance = 0;

        public void Deposit(double dep)
        {
            balance = balance + dep;

        }

        public void Withdraw(double dep)
        {
            balance = balance - dep;

        }


        public double GetBalance()
        {

            return balance;

        }


    }
}

