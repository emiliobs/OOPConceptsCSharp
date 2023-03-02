namespace OOPConcepts.Logic
{
    public abstract class Employee : IPay
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
            return $"Id Code.............: {Id}\n\t" +
                   $"Full Name...........: {FullName}\n\t" +
                   $"Hired...............: {BortDate}";
        }

        public abstract decimal GetValueToPay();
    }
}
