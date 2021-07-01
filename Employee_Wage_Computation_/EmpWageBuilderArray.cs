using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation_
{
    public class EmpWageBuilderArray
    {
        //(constant)
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private int numofCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;


        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[50];
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numofCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numofCompany++;
        }
        /// <summary>
        /// method to compute emp wage
        /// </summary>
        public void computeEmpWage()
        {
            for (int i = 0; i < numofCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].ToString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {

            //variable
            int empHrs = 0;
            int totalEmpHours = 0;
            int totalWorkingDays = 0;
            while (totalEmpHours <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
            return totalEmpHours * companyEmpWage.empRatePerHour;
        }
    }
}

