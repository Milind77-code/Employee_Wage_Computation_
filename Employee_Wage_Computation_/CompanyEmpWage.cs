using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation_
{
    class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        /// <summary>
        /// constructor with parameters
        /// </summary>
        /// <param name="company"></param>
        /// <param name="empRatePerHour"></param>
        /// <param name="numOfWorkingDays"></param>
        /// <param name="maxHoursPerMonth"></param>
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;

        }

        /// <summary>
        /// method to set total wage
        /// </summary>
        /// <param name="totalEmpWage"></param>
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string tostring()
        {
            return "Total Emp Wage for company :- " + this.company + "is:" + this.totalEmpWage;

        }
    }
}
