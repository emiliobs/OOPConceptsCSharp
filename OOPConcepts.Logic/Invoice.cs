﻿namespace OOPConcepts.Logic
{
    public class Invoice : IPay
    {

        public int Id { get; set; }

        public string Description { get; set; }

        public float Quantity { get; set; }

        public decimal Price { get; set; }


        public override string ToString()
        {
            return $"        Id...................: {Id}\n\t" +
                   $"Description..........: {Description}\n\t" +
                   $"Quantity.............: {Quantity,20:N2}\n\t" +
                   $"Price................: {Price,20:C2}\n\t" +
                   $"Value to Pay.........: {GetValueToPay(),20:C2}";
        }


        public decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }
    }
}
