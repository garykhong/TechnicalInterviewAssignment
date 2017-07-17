using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class AnagramDetector_GetCharacterDeleteCountToMakeAnagram
    {

        [TestMethod]
        public void FirstStringcdeSecondStringabc_Gives4()
        {            
            Assert.AreEqual(4, 
                GetCharacterDeleteCountToMakeAnagram("cde", "abc"));
        }

        [TestMethod]
        public void FirstStringcdeSecondStringedc_Gives0()
        {
            Assert.AreEqual(0,
                GetCharacterDeleteCountToMakeAnagram("cde", "edc"));
        }

        [TestMethod]
        public void FirstStringaaBBccDDSecondStringedcE_Gives7()
        {
            Assert.AreEqual(8,
                GetCharacterDeleteCountToMakeAnagram("aaBBccDD", "cE"));
        }

        [TestMethod]
        public void FirstStringfcrxzwscanmligyxyvymSecondStringjxwtrhvujlmrpdoqbisbwhmgpmeoke_Gives30()
        {
            Assert.AreEqual(30,
                GetCharacterDeleteCountToMakeAnagram("fcrxzwscanmligyxyvym", "jxwtrhvujlmrpdoqbisbwhmgpmeoke"));
        }

        [TestMethod]
        public void FirstStringaaBBcSecondStringedaaBBd_Gives2()
        {
            Assert.AreEqual(2,
                GetCharacterDeleteCountToMakeAnagram("aaBBc", "aaBBd"));
        }

        private int GetCharacterDeleteCountToMakeAnagram(string firstString,
                                                          string secondString)
        {
            AnagramDetector anagramDetector = 
                new AnagramDetector(firstString, secondString);
            return anagramDetector.GetCharacterDeleteCountToMakeAnagram();
        }
    }
}
