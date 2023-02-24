using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic
{
	public class BaseCommissionEmployee : CommisionEmployee 
	{
		private decimal _salary;

		public decimal Salary 
		{
			get => _salary;
			set => _salary = ValidateSalary(value);
		}

        public override string ToString()
        {
            return $"	{Id}\t{FirstName} {LastName}\n\t"                         + 
				   $"Hired................: {BortDate}\n\t"                        +
				   $"Commission Percentaje: {CommissionPercentaje ,20:P2}\n\t" +
				   $"Base Salary..........: {Salary, 20:C2}\n\t"			   +
				   $"Sale.................: {Sales, 20:C2}\n\t"				   +
				   $"Value to Pay.........: {GetValueToPay(), 20:C2}";

		}

        public override decimal GetValueToPay()
        {
				
			var salary = base.GetValueToPay() + Salary; 
			
			if (salary < 600000)
			{
				throw new ArgumentException("The salary base is not valid.");
			}

			return salary;
        }

        private decimal ValidateSalary(decimal value) 
		{
			if (value < 600000)
			{
				throw new ArgumentException("The salary base is not valid.");
			}

			return value;
		}
	}

}


