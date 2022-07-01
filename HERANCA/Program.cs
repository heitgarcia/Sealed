
using System;
using System.Globalization;
using System.Collections.Generic;
using HERANCA.Entities;

namespace HERANCA
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account(1001, "Alex", 500.00);
            Account acc2 = new SavingsAccount(1002, "Anaa", 500.00, 0.01);


            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance); //para argumentos instanciados em account e no BusinessAccount, utilizarao os metodo da Account
            Console.WriteLine(acc2.Balance); //para argumentos instanciados em SavingsAccount, utilizarao o metodo sobrescrito da Account 



        }

    }
}