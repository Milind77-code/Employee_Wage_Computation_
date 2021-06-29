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
        public const int NUM_OF_WORKING_DAYS = 2;

        public void EmpPresent()
        {
            //variable
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                //Computing
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        Console.WriteLine("when Employee is Working Part Time.");
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        Console.WriteLine("when Employee is Working Full Time.");
                        break;

                    default:
                        empHrs = 0;
                        Console.WriteLine("when Employee is Absent");
                        break;
                }
                totalEmpWage += empWage;
                empWage = empHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Employee Wage :- " + empWage);
            }
            Console.WriteLine("Total Employee Wage :- " + totalEmpWage);
        }
    }
}
