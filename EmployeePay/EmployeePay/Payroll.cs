using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EmployeePay
{
    public abstract class Employee
    {
        public Employee() { } // empty constructor

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public abstract double Pay { get; } // override in class
    }

    public class Salary : Employee
    {
        public Salary() { } // empty constructor

        public double MonthlySalaryAmount { get; set; }
        public double Bonus { get; set; }
        public override double Pay // salaried employees paid twice a month
        {
            get
            {
                return (MonthlySalaryAmount / 2) + Bonus;
            }
        }
    }

    public class Sales : Employee
    {
        public Sales() { } // empty constructor

        public double Draw { get; set; }
        public double CommissionRate { get; set; }
        public double GrossSales { get; set; }
        public override double Pay
        {
            get
            {
                if (CommissionRate * GrossSales >= Draw)
                {
                    return CommissionRate * GrossSales;
                }
                else
                {
                    return Draw;
                }
            }
        }
    }

    public class Hourly : Employee
    {
        public Hourly() { } // empty constructor

        public double Hours { get; set; }
        public double HourlyRate { get; set; }
        public override double Pay
        {
            get
            {
                if (Hours <= 40)
                {
                    return HourlyRate * Hours;
                }
                else
                {
                    return (HourlyRate * Hours) + (1.5 * HourlyRate * Hours); // overtime pay
                }
            }
        }
    }
}
