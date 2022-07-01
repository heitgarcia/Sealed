using System;
namespace HERANCA.Entities
{
    class BusinessAccount : Account // todos os atributos e metodos que a Account possui, essa nova classe tambem tera
    {

        public double Loanlimit { get; set; }

        public BusinessAccount() //construtor vazio serve para dar a opcao de criar os objetos sem passar os dados
        {
            
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base (number, holder,balance)
            // este construtor possui os mesmo parametros do construtor da outra classe + o LoanLimit, logo basta chama-los com o : base e instanciar
            // o novo argumento
        {
            Loanlimit = loanLimit;
        }

        public void Loan (double amount)
        {
            if (amount <= Loanlimit)
            {
                Balance += amount;
            }
            
        }
    }
}

