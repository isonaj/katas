using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greed
{
    public class Scorer
    {
        public int Score(int[] dice)
        {
            var available = new List<int>(dice);
            var score = 0;
            score += ScoreTriples(available);
            score += ScoreOnes(available);
            score += ScoreFives(available);

            return score;
        }
        private int ScoreOnes(List<int> dice)
        {
            return 100 * dice.Where(d => d == 1).Count();
        }

        private int ScoreFives(List<int> dice)
        {
            return 50 * dice.Where(d => d == 5).Count();
        }

        private int ScoreTriples(List<int> dice)
        {
            if (dice.Where(d => d == 1).Count() >= 3) return 1000;
            if (dice.Where(d => d == 2).Count() >= 3) return 200;
            if (dice.Where(d => d == 3).Count() >= 3) return 300;
            if (dice.Where(d => d == 4).Count() >= 3) return 400;
            if (dice.Where(d => d == 5).Count() >= 3) return 500;
            if (dice.Where(d => d == 6).Count() >= 3) return 600;
            return 0;
        }
    }
}
