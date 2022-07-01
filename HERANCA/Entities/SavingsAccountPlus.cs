using System;
namespace HERANCA.Entities
{
     class SavingsAccountPlus : SavingsAccount; // nao permite pois a SavingsAccount esta selada
    {
        public sealed override void Withdraw(double amount) // com o Sealed no metodo, nao se pode mais sobrescreve-lo (Evita erros acumulados) 
        {
            Balance -= amount;
        }

    }
}

