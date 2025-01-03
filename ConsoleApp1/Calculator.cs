using CloseOpenExample.TypesInterestRateCalculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloseOpenExample
{
    public static class Calculator
    {
        public static void CalculateInterest(Account account)
        {
            account.Interest = account.CalcInterest(new TypeSalaryRateCalculation());
            Console.WriteLine($"По зарплате: {account.Interest}");

            account.Interest = account.CalcInterest(new TypeSimpleRateCalculation());
            Console.WriteLine($"Обычный: {account.Interest}");

        }
    }
}
