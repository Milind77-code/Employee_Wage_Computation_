using System;

namespace Employee_Wage_Computation_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Welocome To Employee Wage Program----");
            Console.WriteLine("-----------------------------------------");
            EmployeeWage.computeEmpWage("DMart", 20, 2, 10);
            Console.WriteLine("-----------------------------------------");
            EmployeeWage.computeEmpWage("Reliance", 10, 4, 20);
        }
    }
}
