using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic 
{
    public class CommisionEmployee : Employee 
    {

        private float _CommissionPercentaje;
       
        private decimal _sales;

        public float CommissionPercentaje 
        {
            get => _CommissionPercentaje;
            set => _CommissionPercentaje = ViladateCommissionPercentaje(value);
        }

       

        public decimal Sales 
        {
            get =>  _sales;
            set => _sales = ValidateSales(value);   
        }
        public override decimal GetValueToPay() 
        {
            return Sales * (decimal)CommissionPercentaje * 0.88m;
        }

        public override string ToString() 
        {
            return $"        {base.ToString()}\n\t" +
                   $"Commission Percentaje: {CommissionPercentaje, 20:p2}\n\t" +
                   $"Sales................: {Sales, 20:C2}\n\t"                +
                   $"Value to Pay.........: {GetValueToPay(), 20:C2}";
        }

        private float ViladateCommissionPercentaje(float value) 
        {
            if (value < 0 || value > 1) 
            {
                throw new ArgumentException("The commission percentaje is not valid.");
            }

            return value;
        }

        private decimal ValidateSales(decimal value) 
        {
            if (value < 0) 
            {
                throw new ArgumentException("The sales value is not valid.");

            }

            return value;

        }

    }
}
