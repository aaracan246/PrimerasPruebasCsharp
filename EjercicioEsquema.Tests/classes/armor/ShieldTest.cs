using EjercicioEsquema.classes;
using EjercicioEsquema.classes.armor;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EjercicioEsquema.Tests.classes.armor;

[TestClass]
[TestSubject(typeof(Shield))]
public class ShieldTest
{

    [TestMethod]
    public void TestApply_AddWhenNotEquipped()
    {
        string shieldName = "testShield";
        int shieldArmor = 10;
        
        Shield shield = new Shield(shieldName, shieldArmor);
        Character character = new Character("testChampion", 10, 10, 10, 10);
        
        shield.Apply(character);
        
        Assert.IsTrue(character.Inventory.Contains(shield), "The shield should be in the inventory.");
    }
}