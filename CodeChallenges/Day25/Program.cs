using Day25.Extensions;
using Day25.NumberConversion;
using TextReaders;

Console.Write($@"
Day 25 Bereken in SNAFU hoeveel brandstof eenheden nodig zijn.

");


try
{
    var fuelRequirementsReader = new TextFileReader { Source = @"Data\FuelRequirements.txt" };
    var numberToSnafuConvertor = new NumberToSnafuConvertor();
    var snafuToNumberConvertor = new SnafuToNumberConvertor();

    var fuelNeeded = fuelRequirementsReader
        .ReadAllLines()
        .Select(snafuNumber => snafuToNumberConvertor.Convert(snafuNumber))
        .Sum();

    var amountOfFuelNeededInSnafuNotation = numberToSnafuConvertor.Convert(fuelNeeded);
    Console.WriteLine($"{amountOfFuelNeededInSnafuNotation} brandstofeenheden nodig (in snafu-units)");
}
catch (Exception exception)
{
    Console.Write("Er is een fout opgetreden", exception);
}
Console.WriteLine("\r\nDruk op een toets.");
Console.ReadKey();