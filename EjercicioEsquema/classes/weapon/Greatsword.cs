namespace EjercicioEsquema.classes.weapon;

public class Greatsword: Weapon
{

    public Greatsword(string name, int dmg) : base(name, dmg)
    {
        damage = dmg;
    }
    public override void Apply(Character character)
    {
        if (!character.Inventory.Contains(this))
        {
            character.Inventory.Add(this);
            SummonFireSpirit(character);
            
        }
        else
        {
            Console.WriteLine("That item is already equipped.");
        }
    }

    private void SummonFireSpirit(Character character)
    {
        if (!character.Pets.Any(pet => pet is FireSpirit))
        {
            FireSpirit fs = new FireSpirit("Pyro", 10, 10, 10);
            character.Pets.Add(fs);
            Console.WriteLine("A fire spirit has been summoned.");
        }
    }
}