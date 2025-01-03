using System;
using System.Security.Principal;

namespace CloseOpenExample.TypesInterestRateCalculation
{
    public class TypeSalaryRateCalculation : ICalculationInterest
    {
        public double ExecuteCalc(double Balance)
        {
            Console.WriteLine("Расчет по зарплате");
            return Balance * 0.5;

        }
    }
}
