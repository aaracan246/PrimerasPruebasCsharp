namespace EjercicioEsquema.classes.armor;

public class Shield: Protection
{
    public Shield(string name, int armor): base(name, armor){}
    

    public override void Apply(Character character)
    {
        if (!character.Inventory.Contains(this))
        {
            character.Inventory.Add(this);
            character.BaseArmor += armor;
        }
        else
        {
            Console.WriteLine("That item is already equipped.");
        }
    }
}