using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStandX
{
    interface IMultiStand
    {
        string Name { get; set; }
        decimal CupsPerDay { get; set; }
        decimal CostPerCup { get; set; }
        decimal PricePerCup { get; set; }

        decimal TotalDailyRevenue();
        
        decimal TotalDailyCost();
        
        decimal TotalDailyProfit();
    }
}
