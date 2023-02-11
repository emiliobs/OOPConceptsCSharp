//using OOPWithCSharp;

using OOPConcepts.Logic;

try
{
    //var date = new Date { Year = 2024, Month = 2, Day = 29, };
    //var date1 = new Date { Year = 2024, Month = 12, Day = 12, };

    var data = new Date(2023, 2, 10);
    var data1 = new Date();
    var date3 = new Date()
    {
        Year = 1890,
        Month = 12,
        Day = 1,
    };
    var date4 = new Date(year: 2025, month: 5, day: 5);

    Console.WriteLine($"Date 1: {data,10}");
    Console.WriteLine($"Date 2: {data1,10}");
    Console.WriteLine($"Date 3: {date3,10}");
    Console.WriteLine($"Date 4: {date4,10}");
}
catch (Exception ex)
{

    Console.WriteLine($"Error: {ex.Message}");
}