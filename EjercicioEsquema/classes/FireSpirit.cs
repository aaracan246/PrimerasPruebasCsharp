using EjercicioEsquema.interfaces;

namespace EjercicioEsquema.classes;

public class FireSpirit(string name, int health, int dmg, int armor): IPet
{
    public int Attack()
    {
        return dmg;
    }

    public int Defend()
    {
        return armor;
    }
}