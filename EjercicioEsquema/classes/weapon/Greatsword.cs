namespace EjercicioEsquema.classes.weapon;

public class Greatsword: Weapon
{
    public Greatsword(string name, int dmg) : base(name, dmg)
    {
    }
    

    public override void Apply(Character character)
    {
        character.BaseDamage += damage;
    }
}