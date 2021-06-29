using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation_
{
    class EmployeeWage
    {
        public void EmpPresent()
        {
            //(constant)
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            //variable
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //Computing
            int empcheck = random.Next(0, 3);
            if (empcheck == IS_PART_TIME)
            {
                empHrs = 4;
                Console.WriteLine("Employee is Working Part Time.");
            }
            else if (empcheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee is Working Full Time.");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");

            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage :- " + empWage);
        }
    }
}
