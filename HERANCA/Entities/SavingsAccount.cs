using System;
namespace HERANCA.Entities
{
    sealed class SavingsAccount : Account //Sealed: impede que outras classes derivem dela
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount (int number, string holder, double balance, double interestRate): base (number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) //Sealed: impede que esse metodo seja sobrescrito novamente
        {
            Balance -= amount;
        }

      
    }
}

