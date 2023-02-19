//using OOPWithCSharp;

using OOPConcepts.Logic;

try
{
    var employee = new Employee() { 
            Id= 100,
            FirstName = "Emilio",
            LastName = "Barrera",
            BortName =  new Date(1975,02,05),
            HireDate = new Date(2023, 12, 02),
            IsActive = true,
    };

    Console.WriteLine(employee);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}