using Greed;
using NUnit.Framework;

namespace Tests
{
    public class ScorerTests
    {
        [Test]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(6)]
        public void ScoreZeroForCertainDice(int dieValue)
        {
            var dice = new int[1] { dieValue };
            var scorer = new Scorer();
            var actual = scorer.Score(dice);

            Assert.AreEqual(0, actual);
        }

        [Test]
        [TestCase(1, 100)]
        [TestCase(5, 50)]
        public void ScoreSingleNumber(int dieValue, int score)
        {
            var dice = new int[1] { dieValue };
            var scorer = new Scorer();
            var actual = scorer.Score(dice);

            Assert.AreEqual(score, actual);
        }

        [Test]
        [TestCase(1, 200)]
        [TestCase(2, 0)]
        [TestCase(5, 100)]
        public void ScoreDoubles(int dieValue, int score)
        {
            var dice = new int[2] { dieValue, dieValue };
            var scorer = new Scorer();
            var actual = scorer.Score(dice);

            Assert.AreEqual(score, actual);
        }

        [Test]
        [TestCase(1, 1000)]
        [TestCase(2, 200)]
        [TestCase(3, 300)]
        [TestCase(4, 400)]
        [TestCase(5, 500)]
        [TestCase(6, 600)]
        public void ScoreTriples(int dieValue, int score)
        {
            var dice = new int[3] { dieValue, dieValue, dieValue };
            var scorer = new Scorer();
            var actual = scorer.Score(dice);

            Assert.AreEqual(score, actual);
        }
    }
}