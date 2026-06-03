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

Console.Write($"Driver: {driver, 40}\n");
Console.Write($"Currency: {currency, 40}\n");

Console.Write($"Distance (miles): {miles, 40}\n");
Console.Write($"Average Speed (MPH): {speed, 40}\n");
double hours = miles / speed;
int wholeHours = (int)hours;
double minutes = (hours - wholeHours) * 60;
string hoursF = $"{hours:F2}";
string minutesF = $"{minutes:F0}";
Console.Write($"Time Driving: {hoursF} hours {minutesF} minutes\n");

Console.Write($"Vehicle Miles per Gallon: {mpg, 40}\n");
double fuelNeededRoundTrip = (miles*2)/mpg;
Console.Write($"Fuel Needed (Round trip): {fuelNeededRoundTrip:#.##, 40} gallons\n");
double tankRange = gallons * mpg;
Console.Write($"Range per tank: {tankRange, 40} miles\n");
int fuelStops = (int)Math.Ceiling(fuelNeededRoundTrip / gallons); //Rounds up! Can't have half a fuel stop.
Console.Write($"Estimated Fuel Stops: {fuelStops, 40}\n");

Console.Write($"Gas Price per Gallon: {currency}{fuelPrice:#.##, 40}\n");
double fuelCostTotal = Math.Ceiling(((miles*2)/mpg)*fuelPrice);
Console.Write($"Estimated Fuel Cost: {currency}{fuelCostTotal, 40} \n");
//fix
Console.Write($"Riders (split): {riders, 40}\n");
double costPerPersonTotal = fuelCostTotal / (riders + 1);
string Snacks = "(+ snacks)";
Console.Write($"Cost per person: {costPerPersonTotal:#.00, 40} {currency} {Snacks}\n");
double costPerMileTotal = fuelCostTotal / (miles*2);
Console.Write($"Cost per mile: {costPerMileTotal:#.00, 40} {currency}\n");
double costPerHourTotal = fuelCostTotal / (miles/speed);
Console.Write($"Cost per driving hour: {costPerHourTotal:#.00, 40} {currency}\n");


