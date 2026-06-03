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
double mpg = Convert.ToInt32(Console.ReadLine());
Console.Write("How many gallons of gas does your car hold?");
int gallons = Convert.ToInt32(Console.ReadLine());  
Console.Write("Excluding the driver, how many riders in the car?");
int riders = Convert.ToInt32(Console.ReadLine());
Console.Write("What unit of currency ($, €, ¥, €) do you use?");
string currency = Console.ReadLine();
Console.Write("What is the fuel price per gallon ($)?");
double fuelPrice = Convert.ToDouble(Console.ReadLine());
//Above includes all variables from the user already converted to usable data types.

Console.Write($"Driver: {driver, 40}");
Console.Write($"Currency: {currency, 40}\n");

Console.Write($"Distance (miles): {miles, 40}");
Console.Write($"Average Speed (MPH): {speed, 40}");
double hours = miles / speed;
Console.Write($"Time Driving: {hours:#.##, 40} hours\n");

Console.Write($" Vechile Miles per Gallon: {mpg, 40}");
double fuelNeededRoundTrip = (miles*2)/mpg;
Console.Write($"Fuel Needed (Round trip): {fuelNeededRoundTrip, 40} gallons");
double tankRange = gallons * mpg;
Console.Write($"Range per tank: {tankRange, 40} miles");
int fuelStops = (int)Math.Ceiling(fuelNeededRoundTrip / gallons); //Rounds up! Can't have half a fuel stop.
Console.Write($"Estimated Fuel Stops: {fuelStops, 40}\n");

Console.Write($"Gas Price per Gallon: {fuelPrice, 40}");
double fuelCostTotal = Math.Ceiling(((miles*2)/mpg)*fuelPrice);
Console.Write($"Estimated Fuel Cost: {fuelCostTotal, 40} {currency}\n");
//fix
Console.Write($"Riders (split): {riders, 40}");
double costPerPersonTotal = fuelCostTotal / (riders + 1);
string Snacks = "(+ snacks)";
Console.Write($"Cost per person: {costPerPersonTotal, 40} {currency} {Snacks}");
double costPerMileTotal = fuelCostTotal / (miles*2);
Console.Write($"Cost per mile: {costPerMileTotal, 40} {currency}");
double costPerHourTotal = fuelCostTotal / (miles/speed);
Console.Write($"Cost per driving hour: {costPerHourTotal, 40} {currency}\n");


