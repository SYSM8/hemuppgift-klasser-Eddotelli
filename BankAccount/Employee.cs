using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double Salary { get; set; }

        public Employee(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        public double GetAnnualSalary()
        {
            return Salary * 12;
        }
        public void GiveRaise(double percentage)
        {
            Salary = Math.Round(Salary * ((percentage / 100) + 1));
        }
    }
}
