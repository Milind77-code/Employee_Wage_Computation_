using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation_
{
    class EmployeeWage
    {
        public void EmpPresent()
        {
            //variable(constant)
            int IS_FULL_TIME = 1;
            Random random = new Random();
            //Computing
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present.");
            }
            else
            {
                Console.WriteLine("Employee is Absent.");
            }
        }
    }
}
