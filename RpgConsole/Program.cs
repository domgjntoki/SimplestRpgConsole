// See https://aka.ms/new-console-template for more information

using RpgConsole.Entities;

Hero hero = new Knight("Arus", 23, "Kinght", 10, 15);
Wizard whiteWizard = new Wizard("Jennica", 23, "White Mage", 10, 40);
Wizard blackWizard = new Wizard("Topapa", 42, "Black Wizard", 385, 641);
Ninja ninja = new Ninja("Wedge", 42, "Ninja", 574, 89);

Hero[] heroes = {hero, whiteWizard, blackWizard, ninja};
foreach (var hero1 in heroes)
{
    Console.Out.WriteLine(hero1);
}
