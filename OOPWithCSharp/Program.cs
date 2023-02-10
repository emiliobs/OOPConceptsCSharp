using OOPWithCSharp;




try
{
    var date = new Date { Year = 2023, Month = 5, Day = 5, };
    var date1 = new Date { Year = 2024, Month = 12, Day = 12, };

    Console.WriteLine(date);
    Console.WriteLine(date1);
}
catch (Exception ex)
{

    Console.WriteLine($"Error: {ex.Message}");
}