// temp <= 0 - freezing, cold
// temp > 0 and temp < 10 - cold
// temp >= 10 and temp < 15 - chilly
// temp >= 15 and temp < 20 - warm
// temp >= 20 and temp < 30 - hot
// temp >= 30 - burning hot

using System.Runtime.CompilerServices;

Console.WriteLine("Enter the temperature:");
int temp = Int32.Parse(Console.ReadLine());

if (temp >= 30)
{
    Console.WriteLine("Burning hot.");
}
else if (temp >= 20 && temp < 30)
{
    Console.WriteLine("Hot.");
}
else if (temp >= 15 && temp < 20)
{
    Console.WriteLine("Warm.");
}
else if (temp >= 10 && temp < 15)
{
    Console.WriteLine("Chilly.");
}
else if (temp > 0  && temp < 10)
{
    Console.WriteLine("Cold.");
}
else
{
    Console.WriteLine("Freezing. Cold.");
}