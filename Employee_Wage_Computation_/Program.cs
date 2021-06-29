using System;

namespace Employee_Wage_Computation_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Welocome To Employee Wage Program----");
            Console.WriteLine("-----------------------------------------");
            EmployeeWage emp = new EmployeeWage();
            emp.computeEmpWage();

        }
    }
}
