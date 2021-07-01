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
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMArt", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
        }
    }
}
