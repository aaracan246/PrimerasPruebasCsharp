// See https://aka.ms/new-console-template for more information

using EjercicioEsquema.classes;
using EjercicioEsquema.classes.armor;
using EjercicioEsquema.classes.weapon;

Character champion = new Character("Morri", 10, 10, 8, 8);

Greatsword gs = new  Greatsword("Flamberge", 10);
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

Console.WriteLine(champion.Name + "'s dmg is " + champion.BaseDamage + ".");
Console.WriteLine(champion.Name + "'s armor is " + champion.BaseArmor + ".");