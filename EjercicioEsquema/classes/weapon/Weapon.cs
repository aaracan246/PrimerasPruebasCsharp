using EjercicioEsquema.interfaces;

namespace EjercicioEsquema.classes.weapon;

public abstract class Weapon(string name, int damage): IItem
{
    protected int damage;

    

    public abstract void Apply(Character character);



}