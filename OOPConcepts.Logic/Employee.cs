﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic
{
    public class Employee
    {
        public int Id { get; set; }

        public string? FirstName { get; set; } 

        public string? LastName { get; set; } 

        public Date? BortName { get; set; }

        public Date? HireDate { get; set; }

        public bool IsActive { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public override string ToString()
        {
            return $"{Id}\t{FullName}\n\t" +
                   $"Hired...............: {BortName}";
        }
    }
}
