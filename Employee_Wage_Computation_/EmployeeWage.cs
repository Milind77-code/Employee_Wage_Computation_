using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation_
{
    class EmployeeWage
    {
        //(constant)
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public void EmpPresent()
        {
            //variable
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //Computing
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    Console.WriteLine("Employee is Working Part Time.");
                    break;


                case IS_FULL_TIME:
                    empHrs = 8;
                    Console.WriteLine("Employee is Working Full Time.");
                    break;

                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is Absent");
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage :- " + empWage);
        }
    }
}
