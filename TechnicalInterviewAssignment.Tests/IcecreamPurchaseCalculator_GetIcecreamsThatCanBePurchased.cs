using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class IcecreamPurchaseCalculator_GetIcecreamsThatCanBePurchased
    {
        [TestMethod]
        public void SampleTestCase_GivesExpectedResult()
        {            
            Assert.AreEqual("1 4",
                GetIcecreamsThatCanBePurchased(4, 5, new int[] { 1, 4, 5, 3, 2 }));
            Assert.AreEqual("1 2",
                GetIcecreamsThatCanBePurchased(4, 4, new int[] { 2, 2, 4, 3 }));
        }
        
        [TestMethod]
        public void TestCase1_GivesExpectedResult()
        {
            Assert.AreEqual("2 3",
                GetIcecreamsThatCanBePurchased(100, 3, new int[] { 5, 25, 75 }));
            Assert.AreEqual("1 4",
                GetIcecreamsThatCanBePurchased(200, 7, new int[] { 150, 24, 79, 50, 88, 345, 3 }));
            Assert.AreEqual("4 5",
                GetIcecreamsThatCanBePurchased(8, 8, new int[] { 2, 1, 9, 4, 4, 56, 90, 3 }));
            Assert.AreEqual("29 46",
                GetIcecreamsThatCanBePurchased(542, 100, new int[] { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 }));
            Assert.AreEqual("4 5",
                GetIcecreamsThatCanBePurchased(101, 5, new int[] { 722, 600, 905, 54, 47 }));


        }

        private string GetIcecreamsThatCanBePurchased(int money, int totalFlavours, int[] iceCreamIds)
        {
            IceCreamPurchaseCalculator calculator = 
                new IceCreamPurchaseCalculator(money, totalFlavours, iceCreamIds);
            return calculator.GetIcecreamsThatCanBePurchased();
        }
    }
}
