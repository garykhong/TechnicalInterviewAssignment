using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class RansomNoteCreator_CanCreateRansomNote
    {
        private static string RansomNoteCanBeCreated = "Yes";
        private static string RansomNoteCannotBeCreated = "No";

        [TestMethod]
        public void MagazineHas_giveMeOneGrandTodayNight_RansomNoteWants_giveOneGrandToday_GivesYes()
        {            
            Assert.AreEqual(RansomNoteCanBeCreated,
                CanCreateRansomNoteAsYesNoAnswer(
                    new string[] { "give", "me", "one", "grand", "today", "night" }, 
                      new string[] { "give", "one", "grand", "today" }));
        }

        [TestMethod]
        public void MagazineHas_twoTimesThreeIsNotFour_RansomNoteWants_twoTimesTwoIsFour_GivesNo()
        {
            Assert.AreEqual(RansomNoteCannotBeCreated,
                CanCreateRansomNoteAsYesNoAnswer(
                    new string[] { "two", "times", "three", "is", "not", "four" },
                      new string[] { "two", "times", "two", "is", "four" }));
        }

        [TestMethod]
        public void MagazineHas_twoTimesTwoIsNotFour_RansomNoteWants_twoTimesTwoIsFour_GivesYes()
        {
            Assert.AreEqual(RansomNoteCanBeCreated,
                CanCreateRansomNoteAsYesNoAnswer(
                    new string[] { "two", "times", "two", "is", "not", "four" },
                      new string[] { "two", "times", "two", "is", "four" }));
        }

        private string CanCreateRansomNoteAsYesNoAnswer(string[] magazineWords, string[] intendedRansomNoteWords)
        {
            return CanCreateRansomNote(magazineWords, intendedRansomNoteWords) ? 
                                       RansomNoteCanBeCreated : RansomNoteCannotBeCreated;
        }
        
        private bool CanCreateRansomNote(string[] magazineWords, string[] intendedRansomNoteWords)
        {
            RansomNoteCreator ransomNoteCreator =
                new RansomNoteCreator(magazineWords, intendedRansomNoteWords);
            return ransomNoteCreator.CanCreateRansomNote();
        }
    }
}
