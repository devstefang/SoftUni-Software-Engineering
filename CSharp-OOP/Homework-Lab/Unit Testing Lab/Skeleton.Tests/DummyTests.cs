using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
    [Test]
    [TestCase(10,10,1)]
    public void IsDummyLosingHealth(
        int health,
        int expirience,
       int attack)
    {
        Dummy dummy = new Dummy(health, expirience);
        dummy.TakeAttack(attack);
        Assert.That(dummy.Health, Is.EqualTo(9));
    }
    [Test]
    [TestCase(0, 10, 1)]
    public void CheckDeadDummyException(
        int health,
        int expirience,
       int attack)
    {
        Dummy dummy = new Dummy(health, expirience);
        Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(attack));
    }
    [Test]
    [TestCase(0, 10, 1)]
    public void CheckDeadDummyExpirience(
        int health,
        int expirience,
       int attack)
    {
        Dummy dummy = new Dummy(health, expirience);
        var expectedResult = 10;
        var actualResult = dummy.GiveExperience();
        Assert.AreEqual(expectedResult, actualResult);

       
    }
    [Test]
    [TestCase(10, 10, 1)]
    public void CheckAliveDummyExpirience(
        int health,
        int expirience,
       int attack)
    {
        Dummy dummy = new Dummy(health, expirience);
        Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
    }
}
