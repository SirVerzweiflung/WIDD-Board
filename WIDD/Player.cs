using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIDD
{
    class Player
    {
        public string name;
        public string profilepictureSource;
        public int[,] score = new int[0, 0];
        public int[] placements = new int[0];

        //funtions
        public int SumOfStandardPoints()
        {
            int sumOfStandardPointsCount = 0;
            for(int i = 0; i < ((this.score.Length) / 2); i++)
            {
                sumOfStandardPointsCount = sumOfStandardPointsCount + this.score[0, i];
            }
            return sumOfStandardPointsCount;
        }

        public int SumOfBonusPoints()
        {
            int sumOfBonusPointsCount = 0;
            for (int i = 0; i < ((this.score.Length) / 2); i++)
            {
                sumOfBonusPointsCount = sumOfBonusPointsCount + this.score[1, i];
            }
            return sumOfBonusPointsCount;
        }

    }
}
