//using OOPWithCSharp;

using OOPConcepts.Logic;
using System.ComponentModel.DataAnnotations;

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
      Id        = 55555,
      FirstName = "Emilio",
      LastName  = "Barrera",
      BortDate  = new Date(1975,05,05),
      HireDate  = new Date(2023,05, 05),
      IsActive  = true,  
      Salary    =  5000, 
    };

    var employee2 = new  HouryEmployee
    {
        Id = 11111             ,            
        FirstName    = "Blanca",
        LastName     = "Linda",
        BortDate     = new Date(2024, 02,02),
        HireDate     = new Date(2025, 03,03),
        IsActive     = true,
        WorkingHours = 160.5f,
        HourValue    = 13.60m,
        
    };

    var employee3 = new CommisionEmployee
    {
        Id = 11111,
        FirstName = "Jasmin",
        LastName = "Marulanda",
        BortDate = new Date(1996, 02, 02),
        HireDate = new Date(2021, 03, 03),
        IsActive = true,
        CommissionPercentaje = 0.05f,
        Sales = 300000000,

    };

    Console.WriteLine("Employee 1: ");
    Console.WriteLine(employee1);      
    Console.WriteLine("Employee 2: ");
    Console.WriteLine(employee2);
    Console.WriteLine();
    Console.WriteLine("Employee 3: ");
    Console.WriteLine(employee3);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}