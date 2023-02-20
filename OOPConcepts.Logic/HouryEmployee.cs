using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic
{
    public class HouryEmployee : Employee
    {

        private float _workingHours;

        private decimal _hourValue;

        public float WorkingHours
        {
            get =>  _workingHours; 
            set => _workingHours = ValidateWorkingHours(value); 
        }


        public decimal HourValue
        {
            get => _hourValue; 
            set => _hourValue = ValidateHourValue(value); 
        }


        public override decimal GetValueToPay()
        {
            return (decimal)WorkingHours * HourValue * 0.55m; 
        }

        public override string ToString()
        {
            return $"        {base.ToString()}\n\t" +
                   $"Workin Hours........: {WorkingHours}\n\t" +
                   $"Hour Value..........: {HourValue:C2}\n\t"     +
                   $"Value to Pay........: {GetValueToPay():c2}";
        }

        private float ValidateWorkingHours(float value)
        {
            if (value < 0 || value > 240)
            {
                throw new ArgumentException("The working hours is no valid.");
            }

            return value;
        }

        private decimal ValidateHourValue(decimal value)
        {
            if (value < 9.80m)
            {
                throw new ArgumentException("The hours value is not valid.");
            }

            return value;
        }


    }
}
