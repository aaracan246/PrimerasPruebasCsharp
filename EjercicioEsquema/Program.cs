// See https://aka.ms/new-console-template for more information

using EjercicioEsquema.classes;
using EjercicioEsquema.classes.armor;
using EjercicioEsquema.classes.weapon;

Character champion = new Character("Morri", 10, 10, 8, 8);

Greatsword gs = new  Greatsword("Flamberge", 10);
//FireSpirit fs = new FireSpirit("Pyro", 10, 10, 10);

Shield sh = new Shield("Holy Ward", 8);

Console.WriteLine(champion.Name + " has arrived!");

Console.WriteLine(". . .");

Console.WriteLine(champion.Name + "'s dmg is " + champion.BaseDamage + ".");
Console.WriteLine(champion.Name + "'s armor is " + champion.BaseArmor + ".");

Console.WriteLine(". . .");

gs.Apply(champion);
sh.Apply(champion);

Console.WriteLine(champion.Name + " is now fully geared!" );

Console.WriteLine(". . .");

Console.WriteLine(champion.Name + "'s base dmg is " + champion.BaseDamage + ". And he attacks for " + champion.Attack() + " dmg.");
Console.WriteLine(champion.Name + "'s base armor is " + champion.BaseArmor + ". And he has " + champion.Defense() + " points of armor.");