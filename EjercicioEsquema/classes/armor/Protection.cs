using EjercicioEsquema.interfaces;

namespace EjercicioEsquema.classes.armor;

public abstract class Protection: IItem
{
    protected string name;
    protected int armor;
    
    public Protection(string name, int armor)
    {
        this.name = name;
        this.armor = armor;
    }

    public int Armor => armor;

    public abstract void Apply(Character character);


}