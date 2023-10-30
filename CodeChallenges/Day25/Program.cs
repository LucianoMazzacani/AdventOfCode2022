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

var amountOfFuelNeededInSnafu_notation = numberToSnafuConvertor.Convert(fuelNeeded);
Console.WriteLine($"{amountOfFuelNeededInSnafu_notation} brandstofeenheden nodig (in snafu-units)");
