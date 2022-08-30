using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    internal class Salary
    {
        public float basicSalary;
        public float houserRent;
        public float medicalAllowance;
        public float conveyance;

        double bsPersent;
        double hrPercent;
        double maPercent;
        double caPercent;

        public float ovetime;
        public double overtimeRet;
        public double totalOvertimeRet;

        public double CalculateSalary(float basicSalary)
        {
            this.bsPersent = 0.5;
            this.hrPercent = 0.2;
            this.maPercent = 0.25;
            this.caPercent = 0.05;

            this.basicSalary = basicSalary;
            this.houserRent = Convert.ToInt32(basicSalary * hrPercent);
            this.medicalAllowance = Convert.ToInt32(basicSalary * maPercent);
            this.conveyance = Convert.ToInt32(basicSalary * caPercent);
            var totalSalary = this.basicSalary + this.houserRent + this.medicalAllowance + this.conveyance;
            this.currency = Currency.BOT;
            return totalSalary;
        }
        public double CalculateByOverTime(double overtime)
        {
            this.overtime = basicSalary;
            var ot = (((overtime / 30) / 8) * 2 * 8);
            return ot;

        }
        public Currency currency;
        private double overtime;
    }
    public enum Currency
    {
        BOT,RS,USD,ERO,CNY,YEN
    }
}
