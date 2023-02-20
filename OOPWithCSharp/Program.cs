//using OOPWithCSharp;

using OOPConcepts.Logic;
using OOPWithCSharp;

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
      LastName  = "Barrera",
      BortDate  = new Date(1975,05,05),
      HireDate  = new Date(2023,05, 05),
      IsActive  = true,  
      Salary    =  5000, 
    };

    Console.WriteLine(employee1);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}