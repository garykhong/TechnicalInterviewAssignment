using System;
using System.Collections.Generic;
using System.Linq;

namespace TechnicalInterviewAssignment
{
    public class IceCreamPurchaseCalculator
    {
        private int money;
        private int originalMoney;
        private int totalFlavours;
        private int[] iceCreamPricesWithIndexAsId;
        private int[] unSortedIceCreamPricesWithIndexAsId;
        private List<int> iceCreamIdsThatCanBePurchased;
        private int iceCreamBinarySearchIndex;
        private int firstIceCreamBinarySearchIndex;
        private int lastIceCreamBinarySearchIndex;

        public IceCreamPurchaseCalculator(int money, int totalFlavours, int[] iceCreamIds)
        {
            this.money = money;
            this.originalMoney = money;
            this.totalFlavours = totalFlavours;
            this.iceCreamPricesWithIndexAsId = iceCreamIds;
            iceCreamIdsThatCanBePurchased = new List<int>();
            iceCreamBinarySearchIndex = totalFlavours;
            lastIceCreamBinarySearchIndex = totalFlavours;
        }

        public string GetIcecreamsThatCanBePurchased()
        {
            unSortedIceCreamPricesWithIndexAsId = new int[iceCreamPricesWithIndexAsId.Length];
            Array.Copy(iceCreamPricesWithIndexAsId,
                        unSortedIceCreamPricesWithIndexAsId,
                          iceCreamPricesWithIndexAsId.Length);
            Array.Sort(iceCreamPricesWithIndexAsId);
            SetIceCreamBinarySearchIndex();
            SetIceCreamIdsThatCanBePurchased();
            iceCreamIdsThatCanBePurchased.Sort();
            return string.Join(" ", iceCreamIdsThatCanBePurchased);
        }

        private void SetIceCreamIdsThatCanBePurchased()
        {
            for (int index = 0; index <= iceCreamBinarySearchIndex; index++)
            {
                int price = iceCreamPricesWithIndexAsId[index];
                int moneyAfterFirstDeduction = money - price;
                iceCreamIdsThatCanBePurchased.Clear();
                iceCreamIdsThatCanBePurchased.Add(GetIceCreamId(price));
                for (int nextIndex = 0; nextIndex <= iceCreamBinarySearchIndex; nextIndex++)
                {
                    price = iceCreamPricesWithIndexAsId[nextIndex];
                    int moneyAfterSecondDeduction = moneyAfterFirstDeduction - price;
                    if (moneyAfterSecondDeduction == 0 && GetIceCreamId(price) > 0)
                    {
                        iceCreamIdsThatCanBePurchased.Add(GetIceCreamId(price));
                        return;
                    }
                }
            }
        }

        private void SetIceCreamBinarySearchIndex()
        {
            bool foundSearchIndex = false;
            int foundPrice = 0;
            int oldPrice = 0;
            List<bool> priceIsGreaterThanMoneyList = new List<bool>();
            while (!foundSearchIndex)
            {
                iceCreamBinarySearchIndex = firstIceCreamBinarySearchIndex +
                                           (lastIceCreamBinarySearchIndex -
                                              firstIceCreamBinarySearchIndex) / 2;
                oldPrice = foundPrice;

                if(iceCreamBinarySearchIndex >= iceCreamPricesWithIndexAsId.Length - 1 ||
                    iceCreamBinarySearchIndex < 0)
                {
                    foundSearchIndex = true;
                }
                else
                {
                    foundPrice = iceCreamPricesWithIndexAsId[iceCreamBinarySearchIndex];
                    if (money > foundPrice)
                    {
                        firstIceCreamBinarySearchIndex++;
                        priceIsGreaterThanMoneyList.Add(true);
                    }
                    else
                    {

                        firstIceCreamBinarySearchIndex--;
                        priceIsGreaterThanMoneyList.Add(false);
                    }

                    if (priceIsGreaterThanMoneyList.Count >= 2)
                    {
                        if (priceIsGreaterThanMoneyList[priceIsGreaterThanMoneyList.Count - 1] !=
                          priceIsGreaterThanMoneyList[priceIsGreaterThanMoneyList.Count - 2])
                        {
                            foundSearchIndex = true;
                        }
                    }
                }                    
            }
        }

        private int GetIceCreamId(int price)
        {
            for (int index = 0; index < unSortedIceCreamPricesWithIndexAsId.Length; index++)
            {
                if (price == unSortedIceCreamPricesWithIndexAsId[index])
                {
                    if (!DoesIceCreamIdExist(index + 1))
                        return index + 1;
                }
            }

            return 0;
        }

        private bool DoesIceCreamIdExist(int id)
        {
            return iceCreamIdsThatCanBePurchased.Where(iceCreamId => iceCreamId == id).ToList().Count > 0;
        }


    }
}
