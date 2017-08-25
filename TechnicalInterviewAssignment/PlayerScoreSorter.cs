using System;
using System.Collections;
namespace TechnicalInterviewAssignment
{
    public class PlayerScoreSorter : IComparer
    {
        private PlayerScore firstPlayerScore;
        private PlayerScore secondPlayerScore;
        public int Compare(object firstPlayerScore, object secondPlayerScore)
        {
            this.firstPlayerScore = (PlayerScore)firstPlayerScore;
            this.secondPlayerScore = (PlayerScore)secondPlayerScore;

            if(this.firstPlayerScore.Score > this.secondPlayerScore.Score)
            {
                return -1;
            }
            else if(this.firstPlayerScore.Score < this.secondPlayerScore.Score)
            {
                return 1;
            }
            else if(this.firstPlayerScore.Score == this.secondPlayerScore.Score)
            {
                return this.firstPlayerScore.Name.CompareTo(this.secondPlayerScore.Name);                
            }

            return 0;
        }
    }
}