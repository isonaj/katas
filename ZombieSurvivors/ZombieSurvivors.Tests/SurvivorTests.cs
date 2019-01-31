using NUnit.Framework;
using ZombieSurvivors;

namespace Tests
{
    public class SurvivorTests
    {
        [Test]
        public void SurvivorHasAName()
        {
            var survivor = new Survivor("Harry");
            Assert.AreEqual("Harry", survivor.Name);
        }

        [Test]
        public void NewSurvivorIsNotWounded()
        {
            var survivor = new Survivor("Harry");

            Assert.AreEqual(false, survivor.IsWounded);
            Assert.AreEqual(false, survivor.IsDead);
        }

        [Test]
        public void SurvivorCanBeWounded()
        {
            var survivor = new Survivor("Harry");
            survivor.Wound();
            Assert.AreEqual(true, survivor.IsWounded);
            Assert.AreEqual(false, survivor.IsDead);
        }

        [Test]
        public void SurvivorCanBeKilledByTwoWounds()
        {
            var survivor = new Survivor("Harry");
            survivor.Wound();
            survivor.Wound();
            Assert.AreEqual(true, survivor.IsDead);
        }

        [Test]
        public void SurvivorStartsTurnWith3Actions()
        {
            var survivor = new Survivor("Harry");
            survivor.StartTurn();
            Assert.AreEqual(3, survivor.Actions);
        }
    }
}