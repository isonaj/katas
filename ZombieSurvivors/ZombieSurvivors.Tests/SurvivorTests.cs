using NUnit.Framework;
using System.Linq;
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

        [Test]
        public void SurvivorCanCarry5Equipment()
        {
            var survivor = new Survivor("Harry");
            for (var i = 0; i < 5; i++)
                survivor.AddEquipment($"Item {i}");

            Assert.AreEqual(5, survivor.Equipment.Count());
        }

        [Test]
        public void SurvivorCanNotCarry6Equipment()
        {
            var survivor = new Survivor("Harry");
            for (var i = 0; i < 5; i++)
                survivor.AddEquipment($"Item {i}");

            try
            {
                survivor.AddEquipment("Item 6");
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }

        [Test]
        public void WoundedSurvivorCanNotCarry5Equipment()
        {
            var survivor = new Survivor("Harry");
            survivor.Wound();
            for (var i = 0; i < 4; i++)
                survivor.AddEquipment($"Item {i}");

            try
            {
                survivor.AddEquipment("Item 5");
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }

        [Test]
        public void WoundedSurvivorDropsEquipment()
        {
            var survivor = new Survivor("Harry");
            for (var i = 0; i < 5; i++)
                survivor.AddEquipment($"Item {i}");
            survivor.Wound();

            Assert.AreEqual(4, survivor.Equipment.Count());
        }
    }
}