using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;
using System.Linq;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class PlayerScoreSorter_ArraySort
    {
        [TestMethod]
        public void SampleTestCase_GivesExpectedResults()
        {
            PlayerScore[] playerScores = { new PlayerScore("amy", 100),
                                                   new PlayerScore("david", 100),
                                                   new PlayerScore("heraldo", 50),
                                                   new PlayerScore("aakansha", 75),
                                                   new PlayerScore("aleksa", 150)};

            CollectionAssert.AreEqual(playerScores.
                                       OrderByDescending(playerScore => playerScore.Score).
                                        ThenBy(playerScore => playerScore.Name).
                                         ToArray(), 
                GetSortedPlayerScores(playerScores));
        }
        
        private PlayerScore[] GetSortedPlayerScores(PlayerScore[] playerScores)
        {
            PlayerScoreSorter sorter = new PlayerScoreSorter();
            PlayerScore[] sortedPlayerScores = new PlayerScore[playerScores.Length];
            Array.Copy(playerScores, sortedPlayerScores, playerScores.Length);
            Array.Sort(sortedPlayerScores, sorter);
            return sortedPlayerScores;
        }
    }
}
