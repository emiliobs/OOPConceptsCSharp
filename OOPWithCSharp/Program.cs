//using OOPWithCSharp;

using OOPConcepts.Logic;

try
{
    //var employee = new Employee() { 
    //        Id= 100,
    //        FirstName = "Emilio",
    //        LastName = "Barrera",
    //        BortName =  new Date(1975,02,05),
    //        HireDate = new Date(2023, 12, 02),
    //        IsActive = true,
    //};

    var employee1 = new SalaryEmployee
    {
        Id = 55555,
        FirstName = "Emilio",
        LastName = "Barrera",
        BortDate = new Date(1975, 05, 05),
        HireDate = new Date(2023, 05, 05),
        IsActive = true,
        Salary = 5000,
    };

    var employee2 = new HouryEmployee
    {
        Id = 11111,
        FirstName = "Blanca",
        LastName = "Linda",
        BortDate = new Date(2024, 02, 02),
        HireDate = new Date(2025, 03, 03),
        IsActive = true,
        WorkingHours = 160.5f,
        HourValue = 13.60m,

    };

    var employee3 = new CommisionEmployee
    {
        Id = 22222,
        FirstName = "Jasmin",
        LastName = "Marulanda",
        BortDate = new Date(1996, 02, 02),
        HireDate = new Date(2021, 03, 03),
        IsActive = true,
        CommissionPercentaje = 0.05f,
        Sales = 300000000,

    };

    var employee4 = new BaseCommissionEmployee
    {
        Id = 55555,
        FirstName = "Clara Jimenes",
        LastName = "Linares",
        BortDate = new Date(1978, 08, 08),
        HireDate = new Date(2021, 05, 05),
        IsActive = true,
        CommissionPercentaje = 0.05f,
        Sales = 5500000,
        Salary = 620000,
    };

    //Console.WriteLine("Employee 1: ");
    //Console.WriteLine(employee1);      
    //Console.WriteLine("Employee 2: ");
    //Console.WriteLine(employee2);
    //Console.WriteLine("Employee 3: ");
    //Console.WriteLine(employee3);
    //Console.WriteLine("Employee 4  ");
    //Console.WriteLine(employee4);

    decimal payRoll = 0;
    var contEmployee = 1;

    Employee[] employees = new Employee[]
    {
        employee1,
        employee2,
        employee3,
        employee4,
    };



    foreach (Employee employee in employees)
    {
        Console.WriteLine("=========  EMPLOYEES ==========");
        Console.WriteLine();
        Console.WriteLine($"Employee {contEmployee++}:\n {employee}\n\t");
        payRoll += employee.GetValueToPay();
    }

    Console.WriteLine($"                               ===================");
    Console.WriteLine($"Total PayRoll                 :{payRoll,20:C2}");

    Console.WriteLine();


    var invoice = new Invoice
    {
        Id = 12345,
        Description = "Papel",
        Quantity = 85,
        Price = 120000,
    };

    var invoice1 = new Invoice
    {
        Id = 12346,
        Description = "iPad",
        Quantity = 3,
        Price = 6800000,
    };

    var invoice2 = new Invoice
    {
        Id = 12347,
        Description = "Mantenimiento a la fotocopiadora",
        Quantity = 84,
        Price = 685000,
    };

    Console.WriteLine("=========  ENVOICES ==========");
    Console.WriteLine();

    decimal totalInvoices = 0;
    Invoice[] invoices = new Invoice[] { invoice, invoice1, invoice2 };
    foreach (var invoiceArray in invoices)
    {
        Console.WriteLine(invoiceArray);
        totalInvoices += invoiceArray.GetValueToPay();
        Console.WriteLine();
    }


    Console.WriteLine($"                               ===================");
    Console.WriteLine($"Total Invoices                :{totalInvoices,20:C2}");

    Console.WriteLine($"                               ===================");
    Console.WriteLine($"                               ===================");
    Console.WriteLine($"General Total                 :{payRoll + totalInvoices,20:C2}");

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}