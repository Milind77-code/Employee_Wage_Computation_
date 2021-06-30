using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation_
{
    public class EmpWageBuilderObject
    {
        //(constant)
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

       

        /// <summary>
        /// constructor of class EmpWageBuilderObject
        /// </summary>
        /// <param name="company"></param>
        /// <param name="empRatePerHour"></param>
        /// <param name="numOfWorkingDays"></param>
        /// <param name="maxHoursPerMonth"></param>
        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void computeEmpWage()
        {
            //variable
            int empHrs = 0;
            int totalEmpHours = 0;
            int totalWorkingDays = 0;
            while (totalEmpHours <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();

                //Computing wage
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
            totalEmpWage = totalEmpHours * this.empRatePerHour;
            Console.WriteLine("Total Employee Wage for company :- " + totalEmpWage);
        }
        public string tostring()
        {
            return "Total Employee Wage for company :- " + this.company + "is :- " + this.totalEmpWage;
        }
    }
}
