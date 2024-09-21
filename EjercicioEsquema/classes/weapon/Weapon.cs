using EjercicioEsquema.interfaces;

namespace EjercicioEsquema.classes.weapon;

public abstract class Weapon: IItem
{
    protected string name;
    protected int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public abstract void Apply(Character character);



}