//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPWithCSharp
//{
//    public class Variables
//    {

//        //For integers
//        int myInt = 55;

//        //For decimal values:
//        float myFloat = 55.56778f;
//        double myDouble = 76895.5634129078;
//        decimal myDecimal = 15280000;

//        //String:
//        string myString = "Emilio Barrera";


//        //Boolean
//        bool myBool = false;

//        Console.WriteLine($"The Integer values is: {myInt,20}");

//Console.WriteLine($"The float values is..: {myFloat,20:P2}");

//Console.WriteLine($"The double values is.: {myDouble,20:N2}");

//Console.WriteLine($"The Decimal values...: {myDecimal,20:C2}");

//Console.WriteLine($"The string value is..: {myString}");

//Console.WriteLine($"The Boolean values is: {myBool}");

//Console.WriteLine($"The Boolean values is: {(myBool ? "Yes" : "No")}");

//Console.WriteLine($"The Boolean values is: {(myBool ? "Yes" : "No")}");
//    }
//}


//try
//{
//    //var date = new Date { Year = 2024, Month = 2, Day = 29, };
//    //var date1 = new Date { Year = 2024, Month = 12, Day = 12, };

//    var data = new Date(2023, 2, 10);
//    var data1 = new Date();
//    var date3 = new Date()
//    {
//        Year = 1890,
//        Month = 12,
//        Day = 1,
//    };
//    var date4 = new Date(year: 2025, month: 5, day: 5);

//    Console.WriteLine($"Date 1: {data,10}");
//    Console.WriteLine($"Date 2: {data1,10}");
//    Console.WriteLine($"Date 3: {date3,10}");
//    Console.WriteLine($"Date 4: {date4,10}");
//}
//catch (Exception ex)
//{

//    Console.WriteLine($"Error: {ex.Message}");
//}