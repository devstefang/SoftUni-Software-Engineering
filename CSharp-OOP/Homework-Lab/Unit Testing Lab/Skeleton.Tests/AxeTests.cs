using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    [Test]
    [TestCase(10,10,10,10,9)]
    [TestCase(5,5,5,5,4)]
    public void DoesWeaponLoseDurability(
        int attack,
        int durability,
        int health,
        int exp,
        int expectedResult)
    {
        Axe axe = new Axe(attack, durability);
        Dummy dummy = new Dummy(health, exp);
        axe.Attack(dummy);
        var actualResult = axe.DurabilityPoints;
        Assert.AreEqual(expectedResult, actualResult);
    }
    [Test]
    public void CheckInvalidDurability()
    {
        Dummy dummy = new Dummy(10, 10);
        Axe axe = new Axe(10, 0);
        Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
    }
}