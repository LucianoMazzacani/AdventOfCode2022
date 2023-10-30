using Day02.Decription;
using Day02.RockPaperScissors;
using TextReaders;

var encryptedStrategyGuideReader = new TextFileReader { Source = @"Data\EncryptedStrategyGuide.txt" };
var strategyDectyptor = new InitialStrategyGuideDecryptor();
var game = new RockPaperScissorsGame();

var encryptedStrategyGuide = encryptedStrategyGuideReader.ReadAllLines();
var strategyGuide = strategyDectyptor.Decrypt(encryptedStrategyGuide);
var result = game.CalculateMyTotalScore(strategyGuide);

Console.WriteLine($"Mijn totale score = {result}");