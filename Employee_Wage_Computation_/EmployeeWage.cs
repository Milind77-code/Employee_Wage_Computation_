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
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HOURS_IN_MONTH = 100;

        public int computeEmpWage()
        {
            Console.WriteLine("<----Welocome To Employee Wage Program---->");
            Console.WriteLine("-------------------------------------------");

            //variable
            int empHrs = 0;
            int totalEmpHours = 0;
            int totalWorkingDays = 0;
            while (totalEmpHours <= MAX_HOURS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                //Computing
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        Console.WriteLine(" when Employee is Working Part Time.");
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        Console.WriteLine(" when Employee is Working Full Time.");
                        break;

                    default:
                        empHrs = 0;
                        Console.WriteLine(" when Employee is Absent");
                        break;
                }
                totalEmpHours += empHrs;
                Console.WriteLine("Day:- " + totalWorkingDays + "  Emp Working Hours :- " + empHrs);
            }
            int totalEmpWage = totalEmpHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage :- " + totalEmpWage);
            return totalEmpWage;
        }
    }
}
