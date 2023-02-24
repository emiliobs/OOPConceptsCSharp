using OOPConcepts.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OOPConcepts.Logic
{
    public class SalaryEmployee: Employee
    {
        private decimal _salary;

        public decimal Salary
        {
            get => _salary;
            set => _salary =  ValidateSalary(value);
        }

        public override decimal GetValueToPay()
        {
            return Salary * 0.55m;
        }

        public override string ToString()
        {
            return $"        {base.ToString()}\n\t"      + 
                   $"Salary..............: {Salary, 20:C2}\n\t" +
                   $"Value to Pay........: {GetValueToPay(),20:C2}";
        }

        private decimal ValidateSalary(decimal value)
        {
            if (value < 2068)
            {
                throw new ArgumentException("The salary is less than minimum.");
            }

            return value;
        }

    }
}
