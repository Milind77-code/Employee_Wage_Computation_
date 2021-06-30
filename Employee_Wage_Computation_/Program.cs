using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;

namespace Employee_Wage_Computation_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Welocome To Employee Wage Program----");
            Console.WriteLine("-----------------------------------------");
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.tostring());
            Console.WriteLine("-----------------------------------------");
            reliance.computeEmpWage();
            Console.WriteLine(reliance.tostring());
        }
    }
}
