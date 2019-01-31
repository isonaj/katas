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
            var score = 0;
            score += ScoreTriples(dice);
            score += ScoreOnes(dice);
            score += ScoreFives(dice);

            return score;
        }
        private int ScoreOnes(int[] dice)
        {
            var score = 0;
            var count = dice.Where(d => d == 1).Count();
            if (count >= 3)
                score += 1000;
            score += count % 3 * 100;
            return score;
        }

        private int ScoreFives(int[] dice)
        {
            var score = 0;
            var count = dice.Where(d => d == 5).Count();
            if (count >= 3)
                score += 500;
            score += count % 3 * 50;
            return score;
        }

        private int ScoreTriples(int[] dice)
        {
            if (dice.Where(d => d == 2).Count() >= 3) return 200;
            if (dice.Where(d => d == 3).Count() >= 3) return 300;
            if (dice.Where(d => d == 4).Count() >= 3) return 400;
            if (dice.Where(d => d == 6).Count() >= 3) return 600;
            return 0;
        }
    }
}
