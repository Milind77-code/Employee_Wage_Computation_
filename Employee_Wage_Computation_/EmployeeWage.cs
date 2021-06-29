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
            int EMP_RATE_PER_HOUR = 20;
            //variable
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computing
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage :- " + empWage);
        }
    }
}
