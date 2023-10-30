using Day02.Decription;
using Day02.RockPaperScissors;
using TextReaders;

var strategyGuideFilename = @"Data\EncryptedStrategyGuide.txt";
Console.Clear();
Console.Write(@$"
    AdventOfCode Day2: Rock Scissors Paper
    
    Aan de hand van een versleutelde 'strategy guide' wordt bepaald hoe het spel gespeeld moet worden.
    Aanvankelijk dachten we dat de versleuteling als volgt was:
    A, X => Rock
    B, Y => Paper
    C, Z => Scissors

    Later bleek dat A,B,C de Rock,Paper,Scissors zet van de tegenpartij is en dat X,Y,Z de te spelen
    strategie X=Verliezen, Y=GelijkSpel, Z=Winnen.

    De strategyguide ({strategyGuideFilename} kan (na aanmelden) gevonden worden in https://adventofcode.com/2022/day/2
");

try
{
    // 'di'
    var encryptedStrategyGuideReader = new TextFileReader { Source = strategyGuideFilename };
    var game = new RockPaperScissorsGame();
    List<(string Name, StrategyGuideDecryptor Decryptor)> strategyGuideDecryptors = new List<(string Name, StrategyGuideDecryptor Decryptor)>
    {
        ( "aanvankelijke decryptie", new InitialStrategyGuideDecryptor() ),
        ( "verbeterde decryptie", new ImprovedStrategyGuideDecryptor() )
    };


    var encryptedStrategyGuide = encryptedStrategyGuideReader.ReadAllLines();
    foreach (var strategyGuideDecryptor in strategyGuideDecryptors)
    {
        var initialStrategyGuide = strategyGuideDecryptor.Decryptor.Decrypt(encryptedStrategyGuide);
        var result = game.CalculateMyTotalScore(initialStrategyGuide);
        Console.WriteLine($"Mijn totale score volgens de {strategyGuideDecryptor.Name} = {result}");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Er is een fout opgetreden bij het verwerken.", ex.Message);
}
Console.WriteLine("Druk op een toets om het programma af te sluiten.");