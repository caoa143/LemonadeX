using System;
using System.Collections.Generic;
using System.Linq;


namespace LemonadeStandX
{
    class LemonCorp
    {

        public string Name { get; set; }
        public List<LemonadeStand> Locations { get; set; } = new List<LemonadeStand>();


        public decimal GetCorpTotalDailyRevenue()
        {
            decimal grandTotalRev = 0;
            foreach (LemonadeStand location in Locations)
            {
                grandTotalRev += location.TotalDailyRevenue();
            }
            return grandTotalRev;
        }

        public decimal GetCorpTotalDailyCost()
        {
            decimal grandTotalCost = 0;
            foreach (LemonadeStand location in Locations)
            {
                grandTotalCost += location.TotalDailyCost();
            }
            return grandTotalCost;
        }

        public decimal GetCorpTotalDailyProfit()
        {
            decimal grandTotalProfit = 0;
            foreach (LemonadeStand location in Locations)
            {
                grandTotalProfit += location.TotalDailyProfit();
            }
            return grandTotalProfit;
        }

        //+++++++INTERFACE FOR OTHER STANDS+++++++++++

        interface IMultiStand
        {
            string Name { get; set; }
            decimal CupsPerDay { get; set; }
            decimal CostPerCup { get; set; }
            decimal PricePerCup { get; set; }

             decimal void TotalDailyRevenue()
            {
                return CupsPerDay * PricePerCup;
            }

             decimal void TotalDailyCost()
            {
                return CupsPerDay * CostPerCup;
            }

            decimal void  TotalDailyProfit()
            {
                return TotalDailyRevenue() - TotalDailyCost();

            }
        }

    }
}
