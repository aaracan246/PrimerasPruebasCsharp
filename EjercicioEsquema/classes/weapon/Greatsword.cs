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
        }
        else
        {
            Console.WriteLine("That item is already equipped.");
        }
    }
}