﻿using EjercicioEsquema.interfaces;

namespace EjercicioEsquema.classes;

public class Character
{
    private string name;
    
    private int maxHitPoints = 10;
    private int currentHitPoints;

    private int baseDamage = 5;
    private int baseArmor = 2;

    private int burnDamage = 2;

    private List<IItem> _inventory = new List<IItem>();  // Esto puede ir en el constructor primario, además, se puede realizar el Apply añadiendo y quitando items del inventario y añadir el inventario con cada movimiento attack o defence
    
    public List<IItem> Inventory { get => _inventory; set => _inventory = value; }

    public Character(string name)
    {
        this.name = name;
        this.currentHitPoints = maxHitPoints;
    }
    
    public string Name => name;
    public int MaxHitPoints => maxHitPoints;
    public int CurrentHitPoints => currentHitPoints;

    public int BaseDamage
    {
        get => baseDamage;
        set => baseDamage = value;
    }

    public int BaseArmor
    {
        get => baseArmor;
        set => baseArmor = value;
    }
    
    
    private int Attack()
    {
        return baseDamage;
    }

    private int Defense()
    {
        return baseArmor;
    }

    private void Heal(int amount)
    {
        currentHitPoints += amount;
        if (currentHitPoints > maxHitPoints)
        {
            currentHitPoints = maxHitPoints;
        }
    }

    private void ReceiveDmg(int damage)
    {
        currentHitPoints -= damage;
        if (currentHitPoints < 0)
        {
            currentHitPoints = 0;
        }
    }
}