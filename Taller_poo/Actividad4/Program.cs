

using ConsoleApp2.Fabrica;
using ConsoleApp2.entities;

Ifactory Factory = new Factory();


Factory.BuildGame(1, "fifa ", "ps5");
Factory.BulidConsole(1, "ps5", "1tb", 25000000);

var game = (game)Factory.BuildGame(2, "god of gard ", "pc");

var console = (console)Factory.BulidConsole(2, "nintendo", "250gb", 1500000);
Console.WriteLine(game);
Console.WriteLine(console);