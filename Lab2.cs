using System.Runtime.InteropServices;

Console.WriteLine("We will plan a summer vacation! I will need to know a few things before we begin to make our trip both enjoyable and affordable!");
Console.Write("First, where would you like to go on vacation?" );
string destination = Console.ReadLine();
Console.Write("Who will be driving?");
string driver = Console.ReadLine();
Console.Write($"How many miles to {destination}?");
int miles = Convert.ToInt32(Console.ReadLine());
Console.Write($"What average speed (MPH) will {driver} be travelling?");
int speed = Convert.ToInt32(Console.ReadLine());    
Console.Write("How many MPG does your car get?");
int mpg = Convert.ToInt32(Console.ReadLine());
Console.Write("How many gallons of gas does your car hold?");
int gallons = Convert.ToInt32(Console.ReadLine());  
Console.Write("Excluding the driver, how many riders in the car?");
int riders = Convert.ToInt32(Console.ReadLine());
Console.Write("What unit of currency ($, €, ¥, €) do you use?");
string currency = Console.ReadLine();
Console.Write("What is the fuel price pergallon ($)?");
double fuelPrice = Convert.ToDouble(Console.ReadLine());
//Above includes all variables from the user already converted to usable data types.

Console.Write($"Driver: {driver, 10}");
Console.Write($"Currency: {currency, 10}\n");

Console.Write($"Distance (miles): {miles, 10}");
Console.Write($"Average Speed (MPH): {speed, 10}");
Console.Write($"Time Driving: {miles/speed, 10} hours\n");

Console.Write($" Vechile Miles per Gallon: {mpg, 10}");
Console.Write($"Fuel Needed (Round trip): {Math.Ceiling((miles*2)/mpg), 10} gallons");
//Math.ceiling round to nearest whole integer. I need to change this to be a double to get the correct answer


