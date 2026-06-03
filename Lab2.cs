using System.Runtime.InteropServices;

Console.WriteLine("We will plan a summer vacation! I will need to know a few things before we begin to make our trip both enjoyable and affordable!");
Console.Write("First, where would you like to go on vacation? ");
string destination = Console.ReadLine();
Console.Write("Who will be driving? ");
string driver = Console.ReadLine();
Console.Write($"How many miles to {destination}? ");
double miles = Convert.ToDouble(Console.ReadLine());
Console.Write($"What average speed (MPH) will {driver} be travelling? ");
double speed = Convert.ToDouble(Console.ReadLine());    
Console.Write("How many MPG does your car get? ");
double mpg = Convert.ToDouble(Console.ReadLine());
Console.Write("How many gallons of gas does your car hold? ");
int gallons = Convert.ToInt32(Console.ReadLine());  
Console.Write("Excluding the driver, how many riders in the car? ");
int riders = Convert.ToInt32(Console.ReadLine());
Console.Write("What unit of currency ($, €, ¥, €) do you use? ");
string currency = Console.ReadLine();
Console.Write("What is the fuel price per gallon ($)? ");
double fuelPrice = Convert.ToDouble(Console.ReadLine());
//Above includes all variables from the user already converted to usable data types.
Console.WriteLine();

Console.Write($"Driver: {driver,50}\n");
Console.Write($"Currency: {currency,46}\n");
Console.WriteLine();

Console.Write($"Distance (miles): {miles,40}\n");
Console.Write($"Average Speed (MPH): {speed,36}\n");
double hours = miles / speed;
int wholeHours = (int)hours;
double minutes = (hours - wholeHours) * 60;
string hoursF = $"{hours:F0}";
string minutesF = $"{minutes:F0}";
Console.Write($"Time Driving: {hoursF,42} hours {minutesF,1} minutes\n");
Console.WriteLine();

Console.Write($"Vehicle Miles per Gallon: {mpg,31}\n");
double fuelNeededRoundTrip = (miles*2)/mpg;
string fuelNeededRoundTripF = $"{fuelNeededRoundTrip:F2}";
Console.Write($"Fuel Needed (Round trip): {fuelNeededRoundTripF,34} gallons\n");
double tankRange = gallons * mpg;
Console.Write($"Range per tank: {tankRange,42} miles\n");
int fuelStops = (int)Math.Ceiling(fuelNeededRoundTrip / gallons); //Rounds up! Can't have half a fuel stop.
Console.Write($"Estimated Fuel Stops: {fuelStops,34}\n");
Console.WriteLine();

string fuelPriceF = $"{fuelPrice:F2}";
Console.Write($"Gas Price per Gallon: {currency,34}{fuelPriceF,1}\n");
double fuelCostTotal = Math.Ceiling(((miles*2)/mpg)*fuelPrice);
Console.Write($"Estimated Fuel Cost: {currency,35}{fuelCostTotal,1} \n");
Console.Write($"Riders (split): {riders,40}\n");
double costPerPersonTotal = fuelCostTotal / (riders + 1);
string Snacks = "(+ snacks)";
string costPerPersonTotalF = $"{costPerPersonTotal:F2}";
Console.Write($"Cost per person: {currency,39}{costPerPersonTotalF} {Snacks,1}\n");
double costPerMileTotal = fuelCostTotal / (miles*2);
string costPerMileTotalF = $"{costPerMileTotal:F2}";
Console.Write($"Cost per mile: {currency,41}{costPerMileTotalF}\n");
double costPerHourTotal = fuelCostTotal / (miles/speed);
string costPerHourTotalF = $"{costPerHourTotal:F2}";
Console.Write($"Cost per driving hour: {currency,33}{costPerHourTotalF}\n");


