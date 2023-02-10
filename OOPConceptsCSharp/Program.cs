//For integers
int myInt = 55;

//For decimal values:
float myFloat = 55.56778f;
double myDouble = 76895.5634129078;
decimal myDecimal = 15280000;

//String:
string myString = "Emilio Barrera";


//Boolean
bool myBool = false;

Console.WriteLine($"The Integer values is: {myInt, 20}");

Console.WriteLine($"The float values is..: {myFloat, 20:P2}");

Console.WriteLine($"The double values is.: {myDouble, 20:N2}");

Console.WriteLine($"The Decimal values...: {myDecimal, 20:C2}");

Console.WriteLine($"The string value is..: {myString}");

Console.WriteLine($"The Boolean values is: {myBool}");

Console.WriteLine($"The Boolean values is: {(myBool ? "Yes" : "No")}");

Console.WriteLine($"The Boolean values is: {(myBool ? "Yes" : "No")}");