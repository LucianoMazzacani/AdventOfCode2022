using Day25.Extensions;
using Day25.NumberConversion;
using TextReaders;

var fuelRequirementsReader = new TextFileReader { Source = @"Data\FuelRequirements.txt" };
var numberToSnafuConvertor = new NumberToSnafuConvertor();
var snafuToNumberConvertor = new SnafuToNumberConvertor();

var fuelNeeded = fuelRequirementsReader
    .ReadAllLines()
    .Select(snafuNumber => snafuToNumberConvertor.Convert(snafuNumber))
    .Sum();

var amountOfFuelNeededInSnafuNotation = numberToSnafuConvertor.Convert(fuelNeeded);
Console.WriteLine($"{amountOfFuelNeededInSnafuNotation} brandstofeenheden nodig (in snafu-units)");