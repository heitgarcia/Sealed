using System;
namespace HERANCA.Entities
{
     class Account
    {
        public int Number { get; private set; } // o Private impede que esses argumentos sejam modificados em outra classe
        public String Holder { get; private set; }
        public double Balance { get; protected set; } // o protected permite que os argumentos so possam ser modificado na classe atual
                                                      // e na subclasse (heranca)

        public Account ()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw (double amount) //virtual: o metodo pode ser sobrescrito nas subclasses
        {
            Balance -= amount + 5.0;
        }

        public void Deposit (double amount)
        {
            Balance += amount;

        }
    }
}

