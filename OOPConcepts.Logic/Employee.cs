using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic
{
    public abstract class Employee
    {
        public int Id { get; set; }

        public string? FirstName { get; set; } 

        public string? LastName { get; set; } 

        public Date? BortDate { get; set; }

        public Date? HireDate { get; set; }

        public bool IsActive { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public override string ToString()
        {
            return $"{Id}\n\t{FullName}\n\t" +
                   $"Hired...............: {BortDate}";
        }

        public abstract decimal GetValueToPay();
    }
}
