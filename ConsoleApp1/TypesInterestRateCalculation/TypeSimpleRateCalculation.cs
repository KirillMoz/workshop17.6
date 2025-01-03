using System;
using System.Security.Principal;

namespace CloseOpenExample.TypesInterestRateCalculation
{
    public class TypeSimpleRateCalculation : ICalculationInterest
    {
        public double ExecuteCalc(double Balance)
        {
            Console.WriteLine("Обычный расчет");
            
            double interest = Balance * 0.4;
            
            if (Balance < 1000)
                interest -= Balance * 0.2;

            return interest;
        }
    }
}
