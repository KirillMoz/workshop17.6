using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloseOpenExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.Balance = 60;
            account.Type = "Обычный";
            Calculator.CalculateInterest(account);

            Account account2 = new Account();
            account.Balance = 90;
            account.Type = "Зарплатный";
            Calculator.CalculateInterest(account);

            Console.ReadKey();
        }
    }
}
