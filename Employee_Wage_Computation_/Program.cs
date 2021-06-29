using System;

namespace Employee_Wage_Computation_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----Welcome to Employee Wage Computation---->");
            Console.WriteLine("----------------------------------------------");
            EmployeeWage emp = new EmployeeWage();
            emp.EmpPresent();
        }
    }
}
